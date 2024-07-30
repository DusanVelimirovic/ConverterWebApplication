using System.Collections.Generic;
using System.Threading.Tasks;
using Converter_Web_Application.ApiLayer;
using Converter_Web_Application.Service.Base;
using Converter_Web_Application.Service.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.Service.Configuration
{
    public class CurrencyConversionService : ICurrencyConversionService
    {
        private readonly IApiClient _apiClient;
        private readonly IConfigurationService _configurationService;
        private readonly IJSRuntime _jsRuntime;
        private readonly Dictionary<string, ICurrencyCommand> _commands;
        private List<CurrencyInfo> _currencyCache;

        public CurrencyConversionService(IApiClient apiClient, IConfigurationService configurationService, IJSRuntime jsRuntime)
        {
            _apiClient = apiClient;
            _configurationService = configurationService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();

            // Register commands
            _commands = new Dictionary<string, ICurrencyCommand>
            {
                { "convert", new ConvertCurrencyCommand() }
            };
        }

        public async Task<Dictionary<string, decimal>> FetchExchangeRatesAsync()
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";
            var jsonResponse = await _apiClient.GetAsync<JObject>(requestUri);

            if (jsonResponse["result"].ToString() == "success")
            {
                return jsonResponse["conversion_rates"].ToObject<Dictionary<string, decimal>>();
            }
            else
            {
                throw new Exception("Failed to fetch exchange rates");
            }
        }

        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            var rates = await FetchExchangeRatesAsync();

            if (fromCurrency == "USD")
            {
                return rates[toCurrency];
            }
            else if (toCurrency == "USD")
            {
                return 1 / rates[fromCurrency];
            }
            else
            {
                var rateFromUSD = rates[fromCurrency];
                var rateToUSD = rates[toCurrency];
                return rateToUSD / rateFromUSD;
            }
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            var exchangeRates = await FetchExchangeRatesAsync();
            return _commands["convert"].Execute(amount, exchangeRates, fromCurrency, toCurrency);
        }

        public async Task<List<CurrencyInfo>> FetchEnrichedCurrencyDataAsync()
        {
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return _currencyCache;
            }

            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData);
                return _currencyCache;
            }

            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";
            var supportedCodes = await _apiClient.GetAsync<List<List<string>>>(requestUri);

            var enrichedCurrencyData = new List<CurrencyInfo>();
            foreach (var code in supportedCodes)
            {
                var flagUrl = await GetCurrencyFlagUrl(code[0]);
                var currencyInfo = new CurrencyInfo
                {
                    CurrencyCode = code[0],
                    CurrencyName = code[1],
                    FlagUrl = flagUrl
                };
                enrichedCurrencyData.Add(currencyInfo);
            }

            _currencyCache = enrichedCurrencyData;
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", Newtonsoft.Json.JsonConvert.SerializeObject(_currencyCache));

            return enrichedCurrencyData;
        }

        private async Task<string> GetCurrencyFlagUrl(string currencyCode)
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/enriched/RSD/{currencyCode}";
            var jsonResponse = await _apiClient.GetAsync<JObject>(requestUri);

            if (jsonResponse.TryGetValue("target_data", out JToken targetData))
            {
                if (targetData["flag_url"] != null)
                {
                    return targetData["flag_url"].ToString();
                }
            }

            return string.Empty;
        }
    }
}

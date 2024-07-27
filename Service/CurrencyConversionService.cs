using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Converter_Web_Application.Service.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.Service
{
    public class CurrencyConversionService : ICurrencyConversionService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfigurationService _configurationService;
        private readonly IJSRuntime _jsRuntime;
        private List<CurrencyInfo> _currencyCache;

        public CurrencyConversionService(HttpClient httpClient, IConfigurationService configurationService, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _configurationService = configurationService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
        }

        public async Task<Dictionary<string, decimal>> FetchExchangeRatesAsync()
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

            var response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var rates = JObject.Parse(jsonResponse)["conversion_rates"].ToObject<Dictionary<string, decimal>>();

            return rates;
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
            var exchangeRate = await GetExchangeRateAsync(fromCurrency, toCurrency);
            return amount * exchangeRate;
        }

        public async Task<List<CurrencyInfo>> FetchEnrichedCurrencyDataAsync()
        {
            // Check in-memory cache
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return _currencyCache;
            }

            // Check local storage
            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData);
                return _currencyCache;
            }

            // Fetch from API if not available in cache
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";

            var response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var supportedCodes = JObject.Parse(jsonResponse)["supported_codes"].ToObject<List<List<string>>>();

            var enrichedCurrencyData = new List<CurrencyInfo>();
            foreach (var code in supportedCodes)
            {
                var flagUrl = await GetCurrencyFlagUrl(code[0]);
                var currencyInfo = new CurrencyInfo
                {
                    CurrencyCode = code[0],
                    CurrencyName = code[1],
                    FlagUrl = flagUrl // Fetch the flag URL separately
                };
                enrichedCurrencyData.Add(currencyInfo);
            }

            // Update caches
            _currencyCache = enrichedCurrencyData;
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", JsonConvert.SerializeObject(_currencyCache));

            return enrichedCurrencyData;
        }

        private async Task<string> GetCurrencyFlagUrl(string currencyCode)
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/enriched/RSD/{currencyCode}";

            var response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonResponse);

            if (jsonObject.TryGetValue("target_data", out JToken targetData))
            {
                if (targetData["flag_url"] != null)
                {
                    return targetData["flag_url"].ToString();
                }
            }

            Console.WriteLine($"Flag URL not found for {currencyCode}");
            // If flag_url is not found, return a default value or handle accordingly
            return string.Empty;
        }
    }
}

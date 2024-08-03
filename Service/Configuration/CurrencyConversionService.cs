using Converter_Web_Application.ApiLayer;
using Converter_Web_Application.Service.Base;
using Converter_Web_Application.Service.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.Service.Configuration
{
    /// <summary>
    /// Service for managing currency conversions and notifying observers of exchange rate updates.
    /// </summary>
    public class CurrencyConversionService : ICurrencyConversionService, ISubject
    {
        private readonly IApiClient _apiClient;
        private readonly IConfigurationService _configurationService;
        private readonly IJSRuntime _jsRuntime;
        private readonly Dictionary<string, ICurrencyCommand> _commands;
        private List<CurrencyInfo> _currencyCache;
        private List<IObserver> _observers;
        private Dictionary<string, decimal> _exchangeRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConversionService"/> class.
        /// </summary>
        /// <param name="apiClient">The API client for making HTTP requests.</param>
        /// <param name="configurationService">The configuration service for accessing settings.</param>
        /// <param name="jsRuntime">The JavaScript runtime for interacting with localStorage.</param>
        public CurrencyConversionService(IApiClient apiClient, IConfigurationService configurationService, IJSRuntime jsRuntime)
        {
            _apiClient = apiClient;
            _configurationService = configurationService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
            _observers = new List<IObserver>();

            // Register commands
            _commands = new Dictionary<string, ICurrencyCommand>
            {
                { "convert", new ConvertCurrencyCommand() }
            };
        }

        /// <summary>
        /// Fetches the latest exchange rates from the API.
        /// </summary>
        /// <returns>A dictionary of exchange rates.</returns>
        public async Task<Dictionary<string, decimal>> FetchExchangeRatesAsync()
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";
            var jsonResponse = await _apiClient.GetAsync<JObject>(requestUri);

            if (jsonResponse["result"].ToString() == "success")
            {
                _exchangeRates = jsonResponse["conversion_rates"].ToObject<Dictionary<string, decimal>>();
                Notify(); // Notify all observers about the update
                return _exchangeRates;
            }
            else
            {
                throw new Exception("Failed to fetch exchange rates");
            }
        }

        /// <summary>
        /// Gets the exchange rate between two currencies.
        /// </summary>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>The exchange rate.</returns>
        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            if (_exchangeRates == null || _exchangeRates.Count == 0)
            {
                await FetchExchangeRatesAsync();
            }

            if (fromCurrency == "USD")
            {
                return _exchangeRates[toCurrency];
            }
            else if (toCurrency == "USD")
            {
                return 1 / _exchangeRates[fromCurrency];
            }
            else
            {
                var rateFromUSD = _exchangeRates[fromCurrency];
                var rateToUSD = _exchangeRates[toCurrency];
                return rateToUSD / rateFromUSD;
            }
        }

        /// <summary>
        /// Converts an amount from one currency to another.
        /// </summary>
        /// <param name="amount">The amount to convert.</param>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>The converted amount.</returns>
        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            var exchangeRates = await FetchExchangeRatesAsync();
            return _commands["convert"].Execute(amount, exchangeRates, fromCurrency, toCurrency);
        }

        /// <summary>
        /// Fetches enriched currency data, including currency codes and flag URLs.
        /// </summary>
        /// <returns>A list of enriched currency data.</returns>
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
            var jsonResponse = await _apiClient.GetAsync<JObject>(requestUri);

            if (jsonResponse["result"].ToString() == "success")
            {
                var supportedCodes = jsonResponse["supported_codes"].ToObject<List<List<string>>>();

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
            else
            {
                throw new Exception("Failed to fetch supported currency codes");
            }
        }

        /// <summary>
        /// Gets the flag URL for a given currency code.
        /// </summary>
        /// <param name="currencyCode">The currency code.</param>
        /// <returns>The flag URL.</returns>
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

        // Implement ISubject methods
        /// <summary>
        /// Attaches an observer to the subject.
        /// </summary>
        /// <param name="observer">The observer to attach.</param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Detaches an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all attached observers of an update.
        /// </summary>
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_exchangeRates);
            }
        }
    }
}

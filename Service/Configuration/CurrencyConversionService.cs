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
        private readonly ICurrencyApiService _currencyApiService;
        private readonly IConfigurationService _configurationService;
        private readonly IJSRuntime _jsRuntime;
        private readonly Dictionary<string, ICurrencyCommand> _commands;
        private readonly List<IObserver> _observers;
        private List<CurrencyInfo> _currencyCache;
        private Dictionary<string, decimal> _exchangeRates;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyConversionService"/> class.
        /// </summary>
        /// <param name="currencyApiService">The API service for currency data.</param>
        /// <param name="configurationService">The configuration service for accessing settings.</param>
        /// <param name="jsRuntime">The JavaScript runtime for interacting with localStorage.</param>
        public CurrencyConversionService(ICurrencyApiService currencyApiService, IConfigurationService configurationService, IJSRuntime jsRuntime)
        {
            _currencyApiService = currencyApiService;
            _configurationService = configurationService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
            _exchangeRates = new Dictionary<string, decimal>();  // Initialize to avoid null warnings
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
            var jsonResponse = await _currencyApiService.GetExchangeRatesAsync(apiKey);

            if (jsonResponse?["result"]?.ToString() == "success")
            {
                _exchangeRates = jsonResponse["conversion_rates"]?.ToObject<Dictionary<string, decimal>>()
                                 ?? throw new Exception("Conversion rates not found in the response.");
                Notify(); // Notify all observers about the update
                return _exchangeRates;
            }

            throw new Exception("Failed to fetch exchange rates");
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
                if (_exchangeRates.TryGetValue(toCurrency, out var rateToUSD))
                {
                    return rateToUSD;
                }
                throw new KeyNotFoundException($"Exchange rate for {toCurrency} not found.");
            }

            if (toCurrency == "USD")
            {
                if (_exchangeRates.TryGetValue(fromCurrency, out var rateFromUSD))
                {
                    return 1 / rateFromUSD;
                }
                throw new KeyNotFoundException($"Exchange rate for {fromCurrency} not found.");
            }

            if (_exchangeRates.TryGetValue(fromCurrency, out var fromRate) &&
                _exchangeRates.TryGetValue(toCurrency, out var toRate))
            {
                return toRate / fromRate;
            }

            throw new KeyNotFoundException($"Exchange rates for {fromCurrency} or {toCurrency} not found.");
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
        public async Task<IReadOnlyList<CurrencyInfo>> FetchEnrichedCurrencyDataAsync()
        {
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return _currencyCache;
            }

            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData)
                                ?? new List<CurrencyInfo>();
                return _currencyCache;
            }

            var apiKey = _configurationService.ExchangeRateApiKey;
            var jsonResponse = await _currencyApiService.GetSupportedCodesAsync(apiKey);

            if (jsonResponse?["result"]?.ToString() == "success")
            {
                var supportedCodes = jsonResponse["supported_codes"]?.ToObject<List<List<string>>>()
                                    ?? new List<List<string>>();

                var enrichedCurrencyData = new List<CurrencyInfo>();
                foreach (var code in supportedCodes)
                {
                    var flagUrl = await GetCurrencyFlagUrl(code[0]);
                    enrichedCurrencyData.Add(new CurrencyInfo
                    {
                        CurrencyCode = code[0],
                        CurrencyName = code[1],
                        FlagUrl = flagUrl
                    });
                }

                _currencyCache = enrichedCurrencyData;
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", Newtonsoft.Json.JsonConvert.SerializeObject(_currencyCache));

                return enrichedCurrencyData;
            }

            throw new Exception("Failed to fetch supported currency codes");
        }

        /// <summary>
        /// Gets the flag URL for a given currency code.
        /// </summary>
        /// <param name="currencyCode">The currency code.</param>
        /// <returns>The flag URL.</returns>
        private async Task<string> GetCurrencyFlagUrl(string currencyCode)
        {
            var apiKey = _configurationService.ExchangeRateApiKey;
            var jsonResponse = await _currencyApiService.GetCurrencyFlagUrlAsync(apiKey, currencyCode);

            return jsonResponse?["target_data"]?["flag_url"]?.ToString() ?? string.Empty;
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

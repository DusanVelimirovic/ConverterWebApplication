using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.ApiLayer
{
    /// <summary>
    /// Service for interacting with the currency API to fetch exchange rates, supported codes, and currency flag URLs.
    /// </summary>
    public class CurrencyApiService : ICurrencyApiService
    {
        private readonly IApiClient _apiClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyApiService"/> class.
        /// </summary>
        /// <param name="apiClient">The API client for making HTTP requests.</param>
        public CurrencyApiService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        /// <summary>
        /// Fetches the latest exchange rates from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <returns>A JSON object containing the latest exchange rates.</returns>
        public async Task<JObject> GetExchangeRatesAsync(string apiKey)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }

        /// <summary>
        /// Fetches the supported currency codes from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <returns>A JSON object containing the supported currency codes.</returns>
        public async Task<JObject> GetSupportedCodesAsync(string apiKey)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }

        /// <summary>
        /// Fetches the currency flag URL for a given currency code from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <param name="currencyCode">The currency code for which to fetch the flag URL.</param>
        /// <returns>A JSON object containing the flag URL for the specified currency code.</returns>
        public async Task<JObject> GetCurrencyFlagUrlAsync(string apiKey, string currencyCode)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/enriched/RSD/{currencyCode}";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }
    }
}

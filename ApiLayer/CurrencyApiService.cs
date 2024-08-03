using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.ApiLayer
{
    public class CurrencyApiService : ICurrencyApiService
    {
        private readonly IApiClient _apiClient;

        public CurrencyApiService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<JObject> GetExchangeRatesAsync(string apiKey)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }

        public async Task<JObject> GetSupportedCodesAsync(string apiKey)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }

        public async Task<JObject> GetCurrencyFlagUrlAsync(string apiKey, string currencyCode)
        {
            var requestUri = $"https://v6.exchangerate-api.com/v6/{apiKey}/enriched/RSD/{currencyCode}";
            return await _apiClient.GetAsync<JObject>(requestUri);
        }
    }
}

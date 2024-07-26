using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.Service
{
    public class CurrencyConversionService : ICurrencyConversionService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public CurrencyConversionService(HttpClient httpClient, IConfigurationService configurationService)
        {
            _httpClient = httpClient;
            _apiKey = configurationService.ExchangeRateApiKey;
        }

        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            var response = await _httpClient.GetStringAsync($"https://v6.exchangerate-api.com/v6/{_apiKey}/pair/{fromCurrency}/{toCurrency}");
            var data = JObject.Parse(response);
            return data["conversion_rate"].Value<decimal>();
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            var rate = await GetExchangeRateAsync(fromCurrency, toCurrency);
            return amount * rate;
        }
    }
}

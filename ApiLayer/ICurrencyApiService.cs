using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.ApiLayer
{
    public interface ICurrencyApiService
    {
        Task<JObject> GetExchangeRatesAsync(string apiKey);
        Task<JObject> GetSupportedCodesAsync(string apiKey);
        Task<JObject> GetCurrencyFlagUrlAsync(string apiKey, string currencyCode);
    }
}

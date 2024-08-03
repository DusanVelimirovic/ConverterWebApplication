using Converter_Web_Application.Service.Models;

namespace Converter_Web_Application.Service.Base
{
    public interface ICurrencyConversionService
    {
        Task<Dictionary<string, decimal>> FetchExchangeRatesAsync();
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);
        Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency);
        Task<IReadOnlyList<CurrencyInfo>> FetchEnrichedCurrencyDataAsync(); // Updated return type
    }
}

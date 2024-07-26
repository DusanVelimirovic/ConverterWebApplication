namespace Converter_Web_Application.Service
{
    public interface ICurrencyConversionService
    {
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);
        Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency);
        Task<Dictionary<string, decimal>> FetchExchangeRatesAsync();
    }
}

namespace Converter_Web_Application.Service
{
    public interface ICurrencyCommand
    {
        decimal Execute(decimal amount, Dictionary<string, decimal> exchangeRates, string fromCurrency, string toCurrency);
    }
}

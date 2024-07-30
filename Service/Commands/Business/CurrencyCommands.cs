namespace Converter_Web_Application.Service
{
    public class ConvertCurrencyCommand : ICurrencyCommand
    {
        public decimal Execute(decimal amount, Dictionary<string, decimal> exchangeRates, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "USD")
            {
                return amount * exchangeRates[toCurrency];
            }
            else if (toCurrency == "USD")
            {
                return amount / exchangeRates[fromCurrency];
            }
            else
            {
                var rateFromUSD = exchangeRates[fromCurrency];
                var rateToUSD = exchangeRates[toCurrency];
                return amount * (rateToUSD / rateFromUSD);
            }
        }
    }
}

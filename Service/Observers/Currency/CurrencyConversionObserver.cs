namespace Converter_Web_Application.Service
{
    public class CurrencyConversionObserver : IObserver
    {
        private Dictionary<string, decimal> _exchangeRates;

        public void Update(Dictionary<string, decimal> exchangeRates)
        {
            _exchangeRates = exchangeRates;
            // Handle the update as needed
            // For example, you could log the update, refresh UI components, etc.
        }
    }
}

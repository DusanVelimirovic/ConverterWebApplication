namespace Converter_Web_Application.Service
{
    public interface IObserver
    {
        void Update(Dictionary<string, decimal> exchangeRates);
    }
}

using Converter_Web_Application.Service.Models;

namespace Converter_Web_Application.Service.Base
{
    /// <summary>
    /// Defines methods for currency conversion operations.
    /// </summary>
    public interface ICurrencyConversionService
    {
        /// <summary>
        /// Gets the exchange rate between two currencies.
        /// </summary>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the exchange rate.</returns>
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);

        /// <summary>
        /// Converts an amount from one currency to another.
        /// </summary>
        /// <param name="amount">The amount to convert.</param>
        /// <param name="fromCurrency">The currency to convert from.</param>
        /// <param name="toCurrency">The currency to convert to.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the converted amount.</returns>
        Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency);

        /// <summary>
        /// Fetches the latest exchange rates from the API.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary of exchange rates.</returns>
        Task<Dictionary<string, decimal>> FetchExchangeRatesAsync();

        /// <summary>
        /// Fetches enriched currency data, including currency codes and flag URLs.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of enriched currency data.</returns>
        Task<List<CurrencyInfo>> FetchEnrichedCurrencyDataAsync();
    }
}

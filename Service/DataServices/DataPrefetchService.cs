using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Collections.Generic;
using Converter_Web_Application.Service.Models;
using Newtonsoft.Json;
using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.DataServices
{
    public class DataPrefetchService
    {
        private readonly ICurrencyConversionService _currencyConversionService;
        private readonly IJSRuntime _jsRuntime;
        private List<CurrencyInfo> _currencyCache;

        public DataPrefetchService(ICurrencyConversionService currencyConversionService, IJSRuntime jsRuntime)
        {
            _currencyConversionService = currencyConversionService;
            _jsRuntime = jsRuntime;
            _currencyCache = new List<CurrencyInfo>();
        }

        public async Task PreFetchDataAsync()
        {
            // Check in-memory cache
            if (_currencyCache != null && _currencyCache.Count > 0)
            {
                return;
            }

            // Check local storage
            var cachedData = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "currencyData");
            if (!string.IsNullOrEmpty(cachedData))
            {
                _currencyCache = JsonConvert.DeserializeObject<List<CurrencyInfo>>(cachedData);
                return;
            }

            // Fetch from API if not available in cache
            _currencyCache = await _currencyConversionService.FetchEnrichedCurrencyDataAsync();

            // Update local storage
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "currencyData", JsonConvert.SerializeObject(_currencyCache));
        }
    }
}

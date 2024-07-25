namespace Converter_Web_Application.Service

{
using Microsoft.Extensions.Configuration;
    public class ConfigurationService
    {
        public string? ExchangeRateApiKey { get; }

        public ConfigurationService(IConfiguration configuration)
        {
            ExchangeRateApiKey = configuration["ExchangeRateApiKey"];
        }
    }
}

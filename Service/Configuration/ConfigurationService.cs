using Converter_Web_Application.Service.Base;

namespace Converter_Web_Application.Service.Configuration
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _configuration;
        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
            ExchangeRateApiKey = _configuration["ExchangeRateApiKey"];
        }

        public string ExchangeRateApiKey { get; }
    }
}

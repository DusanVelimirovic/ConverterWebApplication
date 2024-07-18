using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Travel
{
    public class TravelConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Register Travel Conversions
            service.RegisterConversion(new CalculateTravelTime());
            service.RegisterConversion(new CalculateNecessarySpeed());
        }

    }
}

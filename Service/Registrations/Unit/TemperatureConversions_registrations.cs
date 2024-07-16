using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class TemperatureConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CelsiusToFahrenheit());
            service.RegisterConversion(new CelsiusToKelvin());
            service.RegisterConversion(new FahrenheitToCelsius());
            service.RegisterConversion(new FahrenheitToKelvin());
            service.RegisterConversion(new KelvinToCelsius());
            service.RegisterConversion(new KelvinToFahrenheit());
        }
    }
}

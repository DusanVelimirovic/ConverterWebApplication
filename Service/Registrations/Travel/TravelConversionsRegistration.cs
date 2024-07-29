namespace Converter_Web_Application.Service.Registrations.Travel
{
    public static class TravelConversionsRegistration
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CalculateTravelTime());
            service.RegisterConversion(new CalculateTravelSpeed());
            service.RegisterConversion(new MphToKmh());
            service.RegisterConversion(new KmhToMph());
        }
    }
}

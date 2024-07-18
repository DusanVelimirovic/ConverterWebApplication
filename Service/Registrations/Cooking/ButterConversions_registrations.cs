using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class ButterConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Register Travel Conversions
            service.RegisterConversion(new CupOfButterToGrams());
            service.RegisterConversion(new CupOfButterToKilograms());
            service.RegisterConversion(new CupOfButterToOunces());
            service.RegisterConversion(new CupOfButterToPounds());
            service.RegisterConversion(new TablespoonOfButterToGrams());
            service.RegisterConversion(new TablespoonOfButterToKilograms());
            service.RegisterConversion(new TablespoonOfButterToOunces());
            service.RegisterConversion(new TablespoonOfButterToPounds());
            service.RegisterConversion(new TeaspoonOfButterToGrams());
            service.RegisterConversion(new TeaspoonOfButterToKilograms());
            service.RegisterConversion(new TeaspoonOfButterToOunces());
            service.RegisterConversion(new TeaspoonOfButterToPounds());

        }

    }
}

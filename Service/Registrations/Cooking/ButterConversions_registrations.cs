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

            service.RegisterConversion(new GramsToCupsOfButter());
            service.RegisterConversion(new KilogramsToCupsOfButter());
            service.RegisterConversion(new OuncesToCupsOfButter());
            service.RegisterConversion(new PoundsToCupsOfButter());
            service.RegisterConversion(new GramsToTablespoonsOfButter());
            service.RegisterConversion(new KilogramsToTablespoonsOfButter());
            service.RegisterConversion(new PoundsToTablespoonsOfButter());
            service.RegisterConversion(new OuncesToTablespoonsOfButter());
            service.RegisterConversion(new KilogramsToTeaspoonsOfButter());
            service.RegisterConversion(new OuncesToTeaspoonsOfButter());
            service.RegisterConversion(new PoundsToTeaspoonsOfButter());
            service.RegisterConversion(new GramsToTeaspoonsOfButter());

        }

    }
}

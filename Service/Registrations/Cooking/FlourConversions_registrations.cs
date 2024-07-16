using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class FlourConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CupOfRiceToGrams());
            service.RegisterConversion(new CupOfRiceToKilograms());
            service.RegisterConversion(new CupOfRiceToOunces());
            service.RegisterConversion(new CupOfRiceToPounds());
            service.RegisterConversion(new TablespoonOfRiceToGrams());
            service.RegisterConversion(new TablespoonOfRiceToKilograms());
            service.RegisterConversion(new TablespoonOfRiceToOunces());
            service.RegisterConversion(new TablespoonOfRiceToPounds());
            service.RegisterConversion(new TeaspoonOfRiceToGrams());
            service.RegisterConversion(new TeaspoonOfRiceToKilograms());
            service.RegisterConversion(new TeaspoonOfRiceToOunces());
            service.RegisterConversion(new TeaspoonOfRiceToPounds());
            service.RegisterConversion(new GramsToCupsOfRice());
            service.RegisterConversion(new KilogramsToCupsOfRice());
            service.RegisterConversion(new OuncesToCupsOfRice());
            service.RegisterConversion(new PoundsToCupsOfRice());
            service.RegisterConversion(new GramsToTablespoonsOfRice());
            service.RegisterConversion(new KilogramsToTablespoonsOfRice());
            service.RegisterConversion(new OuncesToTablespoonsOfRice());
            service.RegisterConversion(new PoundsToTablespoonsOfRice());
            service.RegisterConversion(new GramsToTeaspoonsOfRice());
            service.RegisterConversion(new KilogramsToTeaspoonsOfRice());
            service.RegisterConversion(new OuncesToTeaspoonsOfRice());
            service.RegisterConversion(new PoundsToTeaspoonsOfRice());
        }
    
    }
}

using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class SugarConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CupOfSugarToGrams());
            service.RegisterConversion(new CupOfSugarToKilograms());
            service.RegisterConversion(new CupOfSugarToOunces());
            service.RegisterConversion(new CupOfSugarToPounds());
            service.RegisterConversion(new TablespoonOfSugarToGrams());
            service.RegisterConversion(new TablespoonOfSugarToKilograms());
            service.RegisterConversion(new TablespoonOfSugarToOunces());
            service.RegisterConversion(new TablespoonOfSugarToPounds());
            service.RegisterConversion(new TeaspoonOfSugarToGrams());
            service.RegisterConversion(new TeaspoonOfSugarToKilograms());
            service.RegisterConversion(new TeaspoonOfSugarToOunces());
            service.RegisterConversion(new TeaspoonOfSugarToPounds());

            service.RegisterConversion(new GramsToCupsOfSugar());
            service.RegisterConversion(new KilogramsToCupsOfSugar());
            service.RegisterConversion(new OuncesToCupsOfSugar());
            service.RegisterConversion(new PoundsToCupsOfSugar());
            service.RegisterConversion(new GramsToTablespoonsOfSugar());
            service.RegisterConversion(new KilogramsToTablespoonsOfSugar());
            service.RegisterConversion(new OuncesToTablespoonsOfSugar());
            service.RegisterConversion(new PoundsToTablespoonsOfSugar());
            service.RegisterConversion(new GramsToTeaspoonsOfSugar());
            service.RegisterConversion(new KilogramsToTeaspoonsOfSugar());
            service.RegisterConversion(new OuncesToTeaspoonsOfSugar());
            service.RegisterConversion(new PoundsToTeaspoonsOfSugar());
        }
    
    }
}

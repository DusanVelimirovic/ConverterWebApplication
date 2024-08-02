using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class FlourConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CupOfFlourToGrams());
            service.RegisterConversion(new CupOfFlourToKilograms());
            service.RegisterConversion(new CupOfFlourToOunces());
            service.RegisterConversion(new CupOfFlourToPounds());
            service.RegisterConversion(new TablespoonOfFlourToGrams());
            service.RegisterConversion(new TablespoonOfFlourToKilograms());
            service.RegisterConversion(new TablespoonOfFlourToOunces());
            service.RegisterConversion(new TablespoonOfFlourToPounds());
            service.RegisterConversion(new TeaspoonOfFlourToGrams());
            service.RegisterConversion(new TeaspoonOfFlourToKilograms());
            service.RegisterConversion(new TeaspoonOfFlourToOunces());
            service.RegisterConversion(new TeaspoonOfFlourToPounds());
            service.RegisterConversion(new GramsToCupsOfFlour());
            service.RegisterConversion(new KilogramsToCupsOfFlour());
            service.RegisterConversion(new OuncesToCupsOfFlour());
            service.RegisterConversion(new PoundsToCupsOfFlour());
            service.RegisterConversion(new GramsToTablespoonsOfFlour());
            service.RegisterConversion(new KilogramsToTablespoonsOfFlour());
            service.RegisterConversion(new OuncesToTablespoonsOfFlour());
            service.RegisterConversion(new PoundsToTablespoonsOfFlour());
            service.RegisterConversion(new GramsToTeaspoonsOfFlour());
            service.RegisterConversion(new KilogramsToTeaspoonsOfFlour());
            service.RegisterConversion(new OuncesToTeaspoonsOfFlour());
            service.RegisterConversion(new PoundsToTeaspoonsOfFlour());
        }
    
    }
}

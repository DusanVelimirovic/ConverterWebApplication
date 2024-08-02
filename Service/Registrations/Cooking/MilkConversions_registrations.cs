using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class MilkConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new CupOfMilkToGrams());
            service.RegisterConversion(new CupOfMilkToKilograms());
            service.RegisterConversion(new CupOfMilkToOunces());
            service.RegisterConversion(new CupOfMilkToPounds());
            service.RegisterConversion(new TablespoonOfMilkToGrams());
            service.RegisterConversion(new TablespoonOfMilkToKilograms());
            service.RegisterConversion(new TablespoonOfMilkToOunces());
            service.RegisterConversion(new TablespoonOfMilkToPounds());
            service.RegisterConversion(new TeaspoonOfMilkToGrams());
            service.RegisterConversion(new TeaspoonOfMilkToKilograms());
            service.RegisterConversion(new TeaspoonOfMilkToOunces());
            service.RegisterConversion(new TeaspoonOfMilkToPounds());


            service.RegisterConversion(new GramsToCupsOfMilk());
            service.RegisterConversion(new KilogramsToCupsOfMilk());
            service.RegisterConversion(new OuncesToCupsOfMilk());
            service.RegisterConversion(new PoundsToCupsOfMilk());
            service.RegisterConversion(new GramsToTablespoonsOfMilk());
            service.RegisterConversion(new KilogramsToTablespoonsOfMilk());
            service.RegisterConversion(new OuncesToTablespoonsOfMilk());
            service.RegisterConversion(new PoundsToTablespoonsOfMilk());
            service.RegisterConversion(new GramsToTeaspoonsOfMilk());
            service.RegisterConversion(new KilogramsToTeaspoonsOfMilk());
            service.RegisterConversion(new OuncesToTeaspoonsOfMilk());
            service.RegisterConversion(new PoundsToTeaspoonsOfMilk());
        }
    
    }
}

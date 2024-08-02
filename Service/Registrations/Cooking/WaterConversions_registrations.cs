using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Cooking
{
    public class WaterConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Register Water Conversions
            service.RegisterConversion(new CupOfWaterToGrams());
            service.RegisterConversion(new CupOfWaterToKilograms());
            service.RegisterConversion(new CupOfWaterToOunces());
            service.RegisterConversion(new CupOfWaterToPounds());
            service.RegisterConversion(new TablespoonOfWaterToGrams());
            service.RegisterConversion(new TablespoonOfWaterToKilograms());
            service.RegisterConversion(new TablespoonOfWaterToOunces());
            service.RegisterConversion(new TablespoonOfWaterToPounds());
            service.RegisterConversion(new TeaspoonOfWaterToGrams());
            service.RegisterConversion(new TeaspoonOfWaterToKilograms());
            service.RegisterConversion(new TeaspoonOfWaterToOunces());
            service.RegisterConversion(new TeaspoonOfWaterToPounds());

            service.RegisterConversion(new GramsToCupsOfWater());
            service.RegisterConversion(new KilogramsToCupsOfWater());
            service.RegisterConversion(new OuncesToCupsOfWater());
            service.RegisterConversion(new PoundsToCupsOfWater());
            service.RegisterConversion(new GramsToTablespoonsOfWater());
            service.RegisterConversion(new KilogramsToTablespoonsOfWater());
            service.RegisterConversion(new OuncesToTablespoonsOfWater());
            service.RegisterConversion(new PoundsToTablespoonsOfWater());

            service.RegisterConversion(new GramsToTeaspoonsOfWater());
            service.RegisterConversion(new KilogramsToTeaspoonsOfWater());
            service.RegisterConversion(new OuncesToTeaspoonsOfWater());
            service.RegisterConversion(new PoundsToTeaspoonsOfWater());

        }

    }
}

using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class AreaConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Square meters
            service.RegisterConversion(new SquaremetersToSquareFeet());
            service.RegisterConversion(new SquaremetersToSquareYards());
            service.RegisterConversion(new SquaremetersToSquareMiles());
            service.RegisterConversion(new SquaremetersToSquareKilometers());
            service.RegisterConversion(new SquaremetersToAcres());
            service.RegisterConversion(new SquaremetersToHectares());
            service.RegisterConversion(new SquaremetersToSquereCentimeters());
            service.RegisterConversion(new SquaremetersToSquereInches());
            service.RegisterConversion(new SquaremetersToSquereMillimeters());

            // Square feet
            service.RegisterConversion(new SquareFeetToSquereMeters());
            service.RegisterConversion(new SquareFeetToSquereYards());
            service.RegisterConversion(new SquareFeetToSquereMiles());
            service.RegisterConversion(new SquareFeetToSquereKilometers());
            service.RegisterConversion(new SquareFeetToAcres());
            service.RegisterConversion(new SquareFeetToHectares());
            service.RegisterConversion(new SquareFeetToSquareCentimeters());
            service.RegisterConversion(new SquareFeetToSquareInches());
            service.RegisterConversion(new SquareFeetToSquareMillimeters());

            // Square yards
            service.RegisterConversion(new SquareYardsToSquareMeters());
            service.RegisterConversion(new SquareYardsToSquareFeet());
            service.RegisterConversion(new SquareYardsToSquareMiles());
            service.RegisterConversion(new SquareYardsToSquareKilometers());
            service.RegisterConversion(new SquareYardsToAcres());
            service.RegisterConversion(new SquareYardsToHectares());
            service.RegisterConversion(new SquareYardsToSquareCentimeters());
            service.RegisterConversion(new SquareYardsToSquareInches());
            service.RegisterConversion(new SquareYardsToSquareMillimeters());

            // Square miles
            service.RegisterConversion(new SquareMilesToSquereMeters());
            service.RegisterConversion(new SquareMilesToSquereFeet());
            service.RegisterConversion(new SquareMilesToSquereYards());
            service.RegisterConversion(new SquareMilesToSquereKilometers());
            service.RegisterConversion(new SquareMilesToAcres());
            service.RegisterConversion(new SquareMilesToHectares());
            service.RegisterConversion(new SquareMilesToSquareCentimeters());
            service.RegisterConversion(new SquareMilesToSquareInches());
            service.RegisterConversion(new SquareMilesToSquareMillimeters());

            // Square kilometers
            service.RegisterConversion(new SquareKilometersToSquereMeters());
            service.RegisterConversion(new SquareKilometersToSquereFeet());
            service.RegisterConversion(new SquareKilometersToSquereYards());
            service.RegisterConversion(new SquareKilometersToSquereMiles());
            service.RegisterConversion(new SquareKilometersToAcres());
            service.RegisterConversion(new SquareKilometersToHectares());
            service.RegisterConversion(new SquareKilometersToCentimeters());
            service.RegisterConversion(new SquareKilometersToInches());
            service.RegisterConversion(new SquareKilometersToMillimeters());


            // Acres
            service.RegisterConversion(new AcresToMeters());
            service.RegisterConversion(new AcresToSquereFeet());
            service.RegisterConversion(new AcresToSquereYards());
            service.RegisterConversion(new AcresToSquereMiles());
            service.RegisterConversion(new AcresToSquereKilometers());
            service.RegisterConversion(new AcresToHectares());
            service.RegisterConversion(new AcresToSquareCentimeters());
            service.RegisterConversion(new AcresToSquareInches());
            service.RegisterConversion(new AcresToSquareMillimeters());

            // Hectares
            service.RegisterConversion(new HectaresToSquereMeters());
            service.RegisterConversion(new HectaresToSquereFeet());
            service.RegisterConversion(new HectaresToSquereYards());
            service.RegisterConversion(new HectaresToSquereMiles());
            service.RegisterConversion(new HectaresToSquereKilometers());
            service.RegisterConversion(new HectaresToAcres());
            service.RegisterConversion(new HectaresToSquareCentimeters());
            service.RegisterConversion(new HectaresToSquareInches());
            service.RegisterConversion(new HectaresToSquareMillimeters());

            // Square centimeters
            service.RegisterConversion(new SquereCentimetersToSquereInches());
            service.RegisterConversion(new SquereCentimetersToSquereMillimeters());
            service.RegisterConversion(new SquereCentimetersToSquareMeters());
            service.RegisterConversion(new SquereCentimetersToSquareFeet());
            service.RegisterConversion(new SquereCentimetersToSquareYards());
            service.RegisterConversion(new SquereCentimetersToSquareMiles());
            service.RegisterConversion(new SquereCentimetersToSquareKilometers());
            service.RegisterConversion(new SquereCentimetersToAcres());


            // Square inches
            service.RegisterConversion(new SquereInchesToSquereCentimeters());
            service.RegisterConversion(new SquereInchesToSquereMillimeters());
            service.RegisterConversion(new SquereInchesToSquereMeters());
            service.RegisterConversion(new SquereInchesToSquereFeet());
            service.RegisterConversion(new SquereInchesToSquereYards());
            service.RegisterConversion(new SquereInchesToSquereMiles());
            service.RegisterConversion(new SquereInchesToSquereKilometers());
            service.RegisterConversion(new SquereInchesToAcres());
            service.RegisterConversion(new SquereInchesToHectares());

            // Square millimeters
            service.RegisterConversion(new SquereMillimetersToSquereInches());
            service.RegisterConversion(new SquereMillimetersToSquereCentimeters());
            service.RegisterConversion(new SquereMillimetersToSquereMeters());
            service.RegisterConversion(new SquereMillimetersToSquereFeet());
            service.RegisterConversion(new SquereMillimetersToSquereYards());
            service.RegisterConversion(new SquereMillimetersToSquereMiles());
            service.RegisterConversion(new SquereMillimetersToSquereKilometers());
            service.RegisterConversion(new SquereMillimetersToAcres());
            service.RegisterConversion(new SquereMillimetersToHectares());
        }
    }
}

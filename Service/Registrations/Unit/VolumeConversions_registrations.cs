using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class VolumeConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Cubic Centimeters
            service.RegisterConversion(new CubicCentimetersToCubicInches());
            service.RegisterConversion(new CubicCentimetersToCubicMeters());
            service.RegisterConversion(new CubicCentimetersToLiters());
            service.RegisterConversion(new CubicCentimetersToMilliliters());

            // Cubic Inches
            service.RegisterConversion(new CubicInchesToCubicCentimeters());
            service.RegisterConversion(new CubicInchesToCubicMeters());
            service.RegisterConversion(new CubicInchesToLiters());
            service.RegisterConversion(new CubicInchesToMilliliters());

            // Cubic Meters
            service.RegisterConversion(new CubicMetersToCubicCentimeters());
            service.RegisterConversion(new CubicMetersToCubicInches());
            service.RegisterConversion(new CubicMetersToLiters());
            service.RegisterConversion(new CubicMetersToMilliliters());

            // Liters
            service.RegisterConversion(new LitersToCubicCentimeters());
            service.RegisterConversion(new LitersToCubicInches());
            service.RegisterConversion(new LitersToCubicMeters());
            service.RegisterConversion(new LitersToMilliliters());

            // Milliliters
            service.RegisterConversion(new MillilitersToCubicInches());
            service.RegisterConversion(new MillilitersToCubicMeters());
            service.RegisterConversion(new MillilitersToLiters());
            service.RegisterConversion(new MillilitersToCubicCentimeters());
        }
    }
}

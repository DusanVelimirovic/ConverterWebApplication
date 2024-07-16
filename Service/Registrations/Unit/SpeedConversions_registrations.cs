using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class SpeedConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Meters per Second
            service.RegisterConversion(new MetersPerSecondToKilometersPerHour());
            service.RegisterConversion(new MetersPerSecondToMilesPerHour());
            service.RegisterConversion(new MetersPerSecondToFeetPerSecond());
            service.RegisterConversion(new MetersPerSecondToKnots());

            // Kilometers Per Hour
            service.RegisterConversion(new KilometersPerHourToMetersPerSecond());
            service.RegisterConversion(new KilometersPerHourToMilesPerHour());
            service.RegisterConversion(new KilometersPerHourToFeetPerSecond());
            service.RegisterConversion(new KilometersPerHourToKnots());

            // Miles per Hour
            service.RegisterConversion(new MilesPerHourToMetersPerSecond());
            service.RegisterConversion(new MilesPerHourToKilometersPerHour());
            service.RegisterConversion(new MilesPerHourToFeetPerSecond());
            service.RegisterConversion(new MilesPerHourToKnots());

            // Feet Per Second
            service.RegisterConversion(new FeetPerSecondToMetersPerSecond());
            service.RegisterConversion(new FeetPerSecondToKilometersPerHour());
            service.RegisterConversion(new FeetPerSecondToMilesPerHour());
            service.RegisterConversion(new FeetPerSecondToKnots());

            // Knots To Meters
            service.RegisterConversion(new KnotsToMetersPerSecond());
            service.RegisterConversion(new KnotsToKilometersPerHour());
            service.RegisterConversion(new KnotsToMilesPerHour());
            service.RegisterConversion(new KnotsToFeetPerSecond());
        }
    }
}

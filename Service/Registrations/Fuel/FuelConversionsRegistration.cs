using Converter_Web_Application.Service.Implementations;

namespace Converter_Web_Application.Service.Registrations.Fuel
{
    public static class FuelConversionsRegistration
    {
        public static void Register(ConversionManagerService service)
        {
            service.RegisterConversion(new MilesPerGallonToLitersPer100Km());
            service.RegisterConversion(new LitersPer100KmToMilesPerGallon());
            service.RegisterConversion(new MpgToLiters());
            service.RegisterConversion(new LitersToMpg());
            service.RegisterConversion(new AverageFuelConsumption());
            service.RegisterConversion(new RequiredFuelForMileage());
            service.RegisterConversion(new PossibleMileageWithFuel());
            service.RegisterConversion(new TravelDistanceWithBudget());
        }
    }
}

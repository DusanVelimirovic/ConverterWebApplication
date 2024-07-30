namespace Converter_Web_Application.Service.Commands.Fuel
{
    public class CalculateAverageFuelConsumptionCommand : IFuelCommand
    {
        public double Execute(double distance, double fuel, double value3 = 0)
        {
            return (fuel / distance) * 100;
        }
    }

    public class CalculateRequiredFuelForMileageCommand : IFuelCommand
    {
        public double Execute(double distance, double averageConsumption, double value3 = 0)
        {
            return (averageConsumption / 100) * distance;
        }
    }

    public class CalculatePossibleMileageWithFuelCommand : IFuelCommand
    {
        public double Execute(double fuel, double averageConsumption, double value3 = 0)
        {
            return (fuel * 100) / averageConsumption;
        }
    }

    public class CalculateTravelDistanceWithBudgetCommand : IFuelCommand
    {
        public double Execute(double budget, double fuelEfficiency, double fuelPrice)
        {
            return (budget / fuelPrice) * fuelEfficiency;
        }
    }
}

using Converter_Web_Application.Service.Commands.Fuel;
using Converter_Web_Application.Service.Registrations.Fuel;
using Converter_Web_Application.Service.Registrations.Travel;
using Converter_Web_Application.Service.Base;

public class ConversionManagerService
{
    private readonly List<IBaseConversion> _conversions = new List<IBaseConversion>();
    private readonly Dictionary<string, IFuelCommand> _fuelCommands = new Dictionary<string, IFuelCommand>();

    public ConversionManagerService()
    {
        // Register conversions
        RegisterConversion(new MphToKmh());
        RegisterConversion(new KmhToMph());
        TravelConversionsRegistration.Register(this);
        FuelConversionsRegistration.Register(this); // Add this line to register fuel conversions
    }

    public void RegisterConversion(IBaseConversion conversion)
    {
        _conversions.Add(conversion);
    }

    public void RegisterFuelCommand(string name, IFuelCommand command)
    {
        _fuelCommands[name] = command;
    }

    public IEnumerable<IBaseConversion> GetAllConversions()
    {
        return _conversions;
    }

    public double Convert(string fromUnit, string toUnit, double value)
    {
        var conversion = _conversions.OfType<IConversion>()
            .FirstOrDefault(c => c.FromUnit.Equals(fromUnit, StringComparison.OrdinalIgnoreCase) &&
                                 c.ToUnit.Equals(toUnit, StringComparison.OrdinalIgnoreCase));

        if (conversion != null)
        {
            return conversion.Convert(value);
        }

        throw new InvalidOperationException($"Conversion from {fromUnit} to {toUnit} not found.");
    }

    public double Convert(string fromUnit, string toUnit, double value1, double value2)
    {
        var conversion = _conversions.OfType<ITravelConversion>()
            .FirstOrDefault(c => c.FromUnit.Equals(fromUnit, StringComparison.OrdinalIgnoreCase) &&
                                 c.ToUnit.Equals(toUnit, StringComparison.OrdinalIgnoreCase));

        if (conversion != null)
        {
            return conversion.Convert(value1, value2);
        }

        throw new InvalidOperationException($"Conversion from {fromUnit} to {toUnit} not found.");
    }

    public double ExecuteFuelCommand(string commandName, double value1, double value2 = 0, double value3 = 0)
    {
        if (_fuelCommands.TryGetValue(commandName, out var command))
        {
            return command.Execute(value1, value2, value3);
        }

        throw new InvalidOperationException($"Fuel command {commandName} not found.");
    }
}

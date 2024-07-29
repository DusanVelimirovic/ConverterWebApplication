using Converter_Web_Application.Service.Registrations.Travel;
using Converter_Web_Application.Service;

public class ConversionManagerService
{
    private readonly List<IBaseConversion> _conversions = new List<IBaseConversion>();

    public ConversionManagerService()
    {
        // Register conversions
        RegisterConversion(new MphToKmh());
        RegisterConversion(new KmhToMph());
        TravelConversionsRegistration.Register(this);
    }

    public void RegisterConversion(IBaseConversion conversion)
    {
        _conversions.Add(conversion);
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
}

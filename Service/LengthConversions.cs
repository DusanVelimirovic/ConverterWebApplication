using Converter_Web_Application.Service;

namespace Converter_Web_Application.Service
{
    public class MetersToKilometers : IConversion
    {
        public int Id => 1;
        public string FromUnit => "meters";
        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }

    public class MetersToCentimeters : IConversion
    {
        public int Id => 2;
        public string FromUnit => "meters";
        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 100;
        }
    }
}

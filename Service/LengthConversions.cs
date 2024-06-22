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

    public class KilometersToMeters : IConversion
    {
        public int Id => 3;

        public string FromUnit => "kilometers";

        public string ToUnit => "meters";

        public double Convert (double value)
        {
            return value * 1000;
        }
    }

    public class MetersToMiles : IConversion
    {
        public int Id => 4;

        public string FromUnit => "meters";

        public string ToUnit => "miles";

        public double Convert(double value)
        {
            return value / 1609.34;
        }
    }

    public class MilesToMeters : IConversion
    {
        public int Id => 5;

        public string FromUnit => "miles";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 1609.34;
        }
    }
}

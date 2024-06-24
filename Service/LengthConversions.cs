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


    public class CentimetersToMeters : IConversion
    {
        public int Id => 7;

        public string FromUnit => "centimeters";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value / 100;
        }
    }

    public class MillimetersToMeters : IConversion
    {
        public int Id => 8;

        public string FromUnit => "millimeters";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value / 1000;
        }
    }

    // Meters to Millimeters: millimeters = meters * 1000

    public class MetersToMillimeters : IConversion
    {
        public int Id => 9;

        public string FromUnit => "meters";

        public string ToUnit => "millimeters";

        public double Convert(double value)
        {
            return value * 1000;
        }
    }

    public class MilesToKilometers : IConversion
    {
        public int Id => 10;

        public string FromUnit => "miles";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 1.60934;
        }
    }


    public class KilometersToMiles : IConversion
    {
        public int Id => 11;

        public string FromUnit => "kilometers";

        public string ToUnit => "miles";

        public double Convert(double value)
        {
            return value * 0.621371;
        }
    }

    // Feet to Meters: meters = feet * 0.3048

    public class FeetToMeters : IConversion
    {
        public int Id => 12;

        public string FromUnit => "feet";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 0.3048;
        }
    }

    // Meters to Feet: feet = meters * 3.28084
    public class MetersToFeet : IConversion
    {
        public int Id => 12;

        public string FromUnit => "meters";

        public string ToUnit => "feet";

        public double Convert(double value)
        {
            return value * 3.28084;
        }
    }


    // Centimeters to Inches: inches = centimeters * 0.393701

    public class CentimetersToInches : IConversion
    {
        public int Id => 13;

        public string FromUnit => "centimeters";

        public string ToUnit => "inches";

        public double Convert(double value)
        {
            return value * 0.393701;
        }
    }

    // centimeters = inches * 2.54

    public class InchesToCentimeters : IConversion
    {
        public int Id => 14;

        public string FromUnit => "inches";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 2.54;
        }
    }


    public class YardsToMeters : IConversion
    {
        public int Id => 15;

        public string FromUnit => "yards";

        public string ToUnit => "meters";

        public double Convert(double value)
        {
            return value * 0.9144;
        }
    }

    // Meters to Yards: yards = meters * 1.09361

    public class MetersToYards : IConversion
    {
        public int Id => 16;

        public string FromUnit => "meters";

        public string ToUnit => "yards";

        public double Convert(double value)
        {
            return value * 1.09361;
        }
    }

    // Nautical Miles to Kilometers: kilometers = nautical miles * 1.852

    public class NauticalMilesToKilometers : IConversion
    {
        public int Id => 17;

        public string FromUnit => "nautical miles";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 1.852;
        }
    }

    // Kilometers to Nautical Miles: nautical miles = kilometers * 0.539957

    public class KilometersToNauticalMiles : IConversion
    {
        public int Id => 18;

        public string FromUnit => "kilometers";

        public string ToUnit => "nautical miles";

        public double Convert(double value)
        {
            return value * 0.539957;
        }
    }

    // Leagues to Kilometers: kilometers = leagues * 4.82803

    public class LeaguesToKilometers : IConversion
    {
        public int Id => 19;

        public string FromUnit => "leagues";

        public string ToUnit => "kilometers";

        public double Convert(double value)
        {
            return value * 4.82803;
        }
    }

    // Kilometers to Leagues: leagues = kilometers * 0.206612

    public class KilometersToLeagues : IConversion
    {
        public int Id => 20;

        public string FromUnit => "kilometers";

        public string ToUnit => "leagues";

        public double Convert(double value)
        {
            return value * 0.206612;
        }
    }




}

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

    // Kilometers to Centimeters: value × 100000 

    public class KilometersToCentimeters : IConversion
    {
        public int Id => 21;

        public string FromUnit => "kilometers";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 100000;
        }
    }

    // Kilometers to Millimeters: value * 1000000

    public class KilometersToMillimeters : IConversion
    {
        public int Id => 22;

        public string FromUnit => "kilometers";

        public string ToUnit => "millimeters";

        public double Convert(double value)
        {
            return value * 1000000;
        }
    }


    // Kilometers to Yards: value * 1093.61

    public class KilometersToYards : IConversion
    {
        public int Id => 23;

        public string FromUnit => "kilometers";

        public string ToUnit => "yards";

        public double Convert(double value)
        {
            return value * 1093.61;
        }
    }

    // Kilometers to Feet: value * 3280.84
    public class KilometersToFeet : IConversion
    {
        public int Id => 24;

        public string FromUnit => "kilometers";

        public string ToUnit => "feet";

        public double Convert(double value)
        {
            return value * 3280.84;
        }
    }


    // Kilometers to Inches: value * 39370.1

    public class KilometersToInches : IConversion
    {
        public int Id => 25;

        public string FromUnit => "kilometers";

        public string ToUnit => "inches";

        public double Convert(double value)
        {
            return value * 39370.1;
        }
    }




    // Miles to Centimeters: value * 160934

    public class MilesToCentimeters : IConversion
    {
        public int Id => 26;

        public string FromUnit => "miles";

        public string ToUnit => "centimeters";

        public double Convert(double value)
        {
            return value * 160934;
        }
    }

    // Miles to Millimeters: value * 1609340

    public class MilesToMillimeters : IConversion
    {
        public int Id => 28;

        public string FromUnit => "miles";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 1609340;
        }
    }

    // Miles to Nautical Miles: value / 1.15078

    public class MilesToNauticalMiles : IConversion
    {
        public int Id => 29;

        public string FromUnit => "miles";

        public string ToUnit => "nautica miles";
        public double Convert(double value)
        {
            return value / 1.15078;
        }
    }

    // Miles to Yards: value * 1760

    public class MilesToYards : IConversion
    {
        public int Id => 30;

        public string FromUnit => "miles";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value * 1760;
        }
    }

    // Miles to Feet: value * 5280

    public class MilesToFeet : IConversion
    {
        public int Id => 31;

        public string FromUnit => "miles";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value * 5280;
        }
    }

    // Miles to Inches: value * 63360

    public class MilesToInches : IConversion
    {
        public int Id => 32;

        public string FromUnit => "miles";

        public string ToUnit => "inches";
        public double Convert(double value)
        {
            return value * 63360;
        }
    }


    // Centimeters to Kilometers: value / 100000

    public class CentimetersToKilometers : IConversion
    {
        public int Id => 33;

        public string FromUnit => "centimeters";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 100000;
        }
    }

    // Centimeters to Miles: value / 160934

    public class CentimetersToMiles : IConversion
    {
        public int Id => 34;

        public string FromUnit => "centimeters";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 160934;
        }
    }

    // Centimeters to Millimeters: value * 10

    public class CentimetersToMillimeters : IConversion
    {
        public int Id => 35;

        public string FromUnit => "centimeters";

        public string ToUnit => "millimeters";
        public double Convert(double value)
        {
            return value * 10;
        }
    }

    // Centimeters to Nautical Miles: value / 185200

    public class CentimetersToNauticalMiles : IConversion
    {
        public int Id => 36;

        public string FromUnit => "centimeters";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 185200;
        }
    }

    // Centimeters to Yards: value / 91.44

    public class CentimetersToYards : IConversion
    {
        public int Id => 37;

        public string FromUnit => "centimeters";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value / 91.44;
        }
    }

    // Centimeters to Feet: value / 30.48
    public class CentimetersToFeet : IConversion
    {
        public int Id => 38;

        public string FromUnit => "centimeters";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value / 30.48;
        }
    }




    // Millimeters to Kilometers: value / 1000000

    public class MillimetersToKilometers : IConversion
    {
        public int Id => 39;

        public string FromUnit => "millimeters";

        public string ToUnit => "kilometers";
        public double Convert(double value)
        {
            return value / 1000000;
        }
    }

    // Millimeters to Miles: value / 1609340

    public class MillimetersToMiles : IConversion
    {
        public int Id => 40;

        public string FromUnit => "millimeters";

        public string ToUnit => "miles";
        public double Convert(double value)
        {
            return value / 1609340;
        }
    }

    // Millimeters to Centimeters: value / 10

    public class MillimetersToCentimeters : IConversion
    {
        public int Id => 41;

        public string FromUnit => "millimeters";

        public string ToUnit => "centimeters";
        public double Convert(double value)
        {
            return value / 10;
        }
    }

    // Millimeters to Nautical Miles: value / 1852000

    public class MillimetersToNauticalMiles : IConversion
    {
        public int Id => 42;

        public string FromUnit => "millimeters";

        public string ToUnit => "nautical miles";
        public double Convert(double value)
        {
            return value / 1852000;
        }
    }

    // Millimeters to Yards: value / 914.4

    public class MillimetersToYards : IConversion
    {
        public int Id => 43;

        public string FromUnit => "millimeters";

        public string ToUnit => "yards";
        public double Convert(double value)
        {
            return value / 914.4;
        }
    }

    // Millimeters to Feet: value / 304.8

    public class MillimetersToFeet : IConversion
    {
        public int Id => 44;

        public string FromUnit => "millimeters";

        public string ToUnit => "feet";
        public double Convert(double value)
        {
            return value / 304.8;
        }
    }




    // Nautical Miles to Meters: value * 1852

    // Nautical Miles to Centimeters: value * 185200

    // Nautical Miles to Millimeters: value * 1852000

    // Nautical Miles to Yards: value * 2025.37

    // Nautical Miles to Feet: value * 6076.12

    // Nautical Miles to Inches: value * 72913.4

    // Yards to Kilometers: value / 1093.61

    // Yards to Miles: value / 1760

    // Yards to Centimeters: value * 91.44

    // Yards to Millimeters: value * 914.4

    // Yards to Nautical Miles: value / 2025.37

    // Yards to Inches: value * 36

    // Feet to Kilometers: value / 3280.84

    // Feet to Miles: value / 5280

    // Feet to Centimeters: value * 30.48

    // Feet to Millimeters: value * 304.8

    // Feet to Nautical Miles: value / 6076.12

    // Feet to Yards: value / 3

    // Inches to Meters: value / 39.3701

    // Inches to Kilometers: value / 39370.1

    // Inches to Miles: value / 63360

    // Inches to Millimeters: value * 25.4

    // Inches to Nautical Miles: value / 72913.4

    // Inches to Yards: value / 36

    // Inches to Feet: value / 12

    // Leagues to Meters: value * 5556

    // Leagues to Centimeters: value * 555600

    // Leagues to Millimeters: value * 5556000

    // Leagues to Nautical Miles: value * 3

    // Leagues to Yards: value * 5280

    // Leagues to Feet: value * 15840

    // Leagues to Inches: value * 190080




}

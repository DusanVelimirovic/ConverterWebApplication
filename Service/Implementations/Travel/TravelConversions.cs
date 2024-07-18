namespace Converter_Web_Application.Service
{
    // Calculate Travel Time
    public class CalculateTravelTime : ITravelConversion
    {
        public int Id => 901;
        public string FromUnit => "distance/speed";
        public string ToUnit => "hours";
        public double Convert(double distance, double speed) => distance / speed;
    }

    // Calculate Necessary Speed
    public class CalculateNecessarySpeed : ITravelConversion
    {
        public int Id => 902;
        public string FromUnit => "distance/time";
        public string ToUnit => "speed";
        public double Convert(double distance, double time) => distance / time;
    }
}

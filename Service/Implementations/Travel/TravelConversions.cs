using Converter_Web_Application.Service;

public class CalculateTravelTime : ITravelConversion
{
    public int Id => 1;
    public string FromUnit => "distance";
    public string ToUnit => "time";
    public double Convert(double distance, double speed)
    {
        return distance / speed;
    }
}

public class CalculateTravelSpeed : ITravelConversion
{
    public int Id => 2;
    public string FromUnit => "distance";
    public string ToUnit => "speed";
    public double Convert(double distance, double time)
    {
        return distance / time;
    }
}

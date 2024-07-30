namespace Converter_Web_Application.Service.Commands.Travel
{
    public class CalculateTravelTimeCommand : ITravelCommand
    {
        public double Execute(double distance, double speed)
        {
            return distance / speed;
        }
    }

    public class CalculateTravelSpeedCommand : ITravelCommand
    {
        public double Execute(double distance, double time)
        {
            return distance / time;
        }
    }
}

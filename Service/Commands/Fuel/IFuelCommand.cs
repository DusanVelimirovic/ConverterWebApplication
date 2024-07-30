namespace Converter_Web_Application.Service.Commands.Fuel
{
    public interface IFuelCommand
    {
        double Execute(double value1, double value2 = 0, double value3 = 0);
    }
}

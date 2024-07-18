namespace Converter_Web_Application.Service
{
    public interface ITravelConversion : IBaseConversion
    {
        double Convert(double value1, double value2);
    }
}

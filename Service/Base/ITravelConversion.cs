namespace Converter_Web_Application.Service.Base
{
    public interface ITravelConversion : IBaseConversion
    {
        double Convert(double value1, double value2);
    }
}

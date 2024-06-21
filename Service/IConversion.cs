namespace Converter_Web_Application.Service
{
    public interface IConversion
    {
        int Id { get; }
        string FromUnit { get; }
        string ToUnit { get; }
        double Convert(double value);
    }
}

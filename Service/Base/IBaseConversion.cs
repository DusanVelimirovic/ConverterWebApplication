namespace Converter_Web_Application.Service.Base
{
    public interface IBaseConversion
    {
        int Id { get; }
        string FromUnit { get; }
        string ToUnit { get; }
    }
}

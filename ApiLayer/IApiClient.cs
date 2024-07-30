namespace Converter_Web_Application.ApiLayer
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string requestUri);
    }
}

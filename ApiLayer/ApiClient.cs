using Newtonsoft.Json;

namespace Converter_Web_Application.ApiLayer
{
    /// <summary>
    /// Implements an API client for making HTTP requests.
    /// </summary>
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for making requests.</param>
        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Sends a GET request to the specified URI and deserializes the response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to which the response content should be deserialized.</typeparam>
        /// <param name="requestUri">The URI to send the GET request to.</param>
        /// <returns>The deserialized response content.</returns>
        /// <exception cref="InvalidOperationException">Thrown when deserialization fails.</exception>
        public async Task<T> GetAsync<T>(string requestUri, string subscriptionKey)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}

using System.Globalization;
using System.Text.Json;

namespace Converter_Web_Application.Service
{
    public class TranslationService
    {
        private readonly HttpClient _httpClient;
        private readonly Dictionary<string, Dictionary<string, string>> _translations;

        public TranslationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _translations = new Dictionary<string, Dictionary<string, string>>();
        }

        public async Task InitializeAsync()
        {
            var translationFiles = new[] { "en.json", "fr.json", "it.json", "ru.json", "sr.json" };
            foreach (var file in translationFiles)
            {
                var culture = Path.GetFileNameWithoutExtension(file);
                var response = await _httpClient.GetAsync($"translations/{file}");
                var content = await response.Content.ReadAsStringAsync();
                var translations = JsonSerializer.Deserialize<Dictionary<string, string>>(content);
                _translations[culture] = translations;
            }
        }

        public string Translate(string key, string culture = null)
        {
            culture ??= CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (_translations.ContainsKey(culture) && _translations[culture].ContainsKey(key))
            {
                return _translations[culture][key];
            }
            return key; // Fallback to key if translation is missing
        }
    }
}

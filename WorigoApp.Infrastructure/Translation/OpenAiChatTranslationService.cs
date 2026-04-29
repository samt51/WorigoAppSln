using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using WorigoApp.Application.Interfaces.Translation;

namespace WorigoApp.Infrastructure.Translation
{
    public class OpenAiChatTranslationService : IChatTranslationService
    {
        private readonly HttpClient _httpClient;
        private readonly OpenAiTranslationSettings _settings;

        public OpenAiChatTranslationService(HttpClient httpClient, IOptions<OpenAiTranslationSettings> options)
        {
            _httpClient = httpClient;
            _settings = options.Value;

            if (!string.IsNullOrWhiteSpace(_settings.BaseUrl))
            {
                _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
            }
        }

        public async Task<TranslationResult> TranslateAsync(string originalText, string sourceLanguageCode, string targetLanguageCode, CancellationToken cancellationToken = default)
        {
            if (string.Equals(sourceLanguageCode, targetLanguageCode, StringComparison.OrdinalIgnoreCase))
            {
                return new TranslationResult
                {
                    SourceLanguageCode = sourceLanguageCode,
                    TargetLanguageCode = targetLanguageCode,
                    OriginalText = originalText,
                    TranslatedText = originalText,
                    NormalizedText = originalText.Trim(),
                    Provider = "OpenAI",
                    Model = _settings.Model
                };
            }

            using var request = new HttpRequestMessage(HttpMethod.Post, "responses");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _settings.ApiKey);

            var payload = new
            {
                model = _settings.Model,
                input = $"Source language: {sourceLanguageCode}\nTarget language: {targetLanguageCode}\nMessage: {originalText}",
                instructions = "You are a hotel support translation assistant. Translate the message faithfully into the target language and return only valid JSON with keys: source_language, target_language, original_text, translated_text, normalized_text.",
                text = new
                {
                    format = new
                    {
                        type = "json_schema",
                        name = "hotel_translation",
                        strict = true,
                        schema = new
                        {
                            type = "object",
                            properties = new
                            {
                                source_language = new { type = "string" },
                                target_language = new { type = "string" },
                                original_text = new { type = "string" },
                                translated_text = new { type = "string" },
                                normalized_text = new { type = "string" }
                            },
                            required = new[] { "source_language", "target_language", "original_text", "translated_text", "normalized_text" },
                            additionalProperties = false
                        }
                    }
                }
            };

            request.Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            using var response = await _httpClient.SendAsync(request, cancellationToken);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
            using var document = JsonDocument.Parse(responseJson);

            var outputText = document.RootElement
                .GetProperty("output")
                .EnumerateArray()
                .First()
                .GetProperty("content")
                .EnumerateArray()
                .First()
                .GetProperty("text")
                .GetString();

            if (string.IsNullOrWhiteSpace(outputText))
            {
                throw new Exception("OpenAI translation response was empty.");
            }

            using var translationDocument = JsonDocument.Parse(outputText);
            var root = translationDocument.RootElement;

            return new TranslationResult
            {
                SourceLanguageCode = root.GetProperty("source_language").GetString() ?? sourceLanguageCode,
                TargetLanguageCode = root.GetProperty("target_language").GetString() ?? targetLanguageCode,
                OriginalText = root.GetProperty("original_text").GetString() ?? originalText,
                TranslatedText = root.GetProperty("translated_text").GetString() ?? originalText,
                NormalizedText = root.GetProperty("normalized_text").GetString() ?? originalText.Trim(),
                Provider = "OpenAI",
                Model = _settings.Model
            };
        }
    }
}

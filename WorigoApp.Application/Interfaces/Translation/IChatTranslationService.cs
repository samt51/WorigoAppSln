namespace WorigoApp.Application.Interfaces.Translation
{
    public interface IChatTranslationService
    {
        Task<TranslationResult> TranslateAsync(string originalText, string sourceLanguageCode, string targetLanguageCode, CancellationToken cancellationToken = default);
    }

    public class TranslationResult
    {
        public string SourceLanguageCode { get; set; } = string.Empty;
        public string TargetLanguageCode { get; set; } = string.Empty;
        public string OriginalText { get; set; } = string.Empty;
        public string TranslatedText { get; set; } = string.Empty;
        public string NormalizedText { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
    }
}

namespace WorigoApp.Application.Interfaces.Translation
{
/// <summary>
/// IChatTranslationService arayüzünü tanımlar.
/// </summary>
public interface IChatTranslationService
    {
        Task<TranslationResult> TranslateAsync(string originalText, string sourceLanguageCode, string targetLanguageCode, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// TranslationResult sınıfını temsil eder.
    /// </summary>
    public class TranslationResult
    {
/// <summary>
/// SourceLanguageCode değerini alır veya ayarlar.
/// </summary>
public string SourceLanguageCode { get; set; } = string.Empty;
/// <summary>
/// TargetLanguageCode değerini alır veya ayarlar.
/// </summary>
public string TargetLanguageCode { get; set; } = string.Empty;
/// <summary>
/// OriginalText değerini alır veya ayarlar.
/// </summary>
public string OriginalText { get; set; } = string.Empty;
/// <summary>
/// TranslatedText değerini alır veya ayarlar.
/// </summary>
public string TranslatedText { get; set; } = string.Empty;
/// <summary>
/// NormalizedText değerini alır veya ayarlar.
/// </summary>
public string NormalizedText { get; set; } = string.Empty;
/// <summary>
/// Provider değerini alır veya ayarlar.
/// </summary>
public string Provider { get; set; } = string.Empty;
/// <summary>
/// Model değerini alır veya ayarlar.
/// </summary>
public string Model { get; set; } = string.Empty;
    }
}

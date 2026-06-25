namespace WorigoApp.Infrastructure.Translation
{
    /// <summary>
    /// OpenAiTranslationSettings sınıfını temsil eder.
    /// </summary>
    public class OpenAiTranslationSettings
    {
/// <summary>
/// ApiKey değerini alır veya ayarlar.
/// </summary>
public string ApiKey { get; set; } = string.Empty;
/// <summary>
/// Model değerini alır veya ayarlar.
/// </summary>
public string Model { get; set; } = "gpt-5-nano";
/// <summary>
/// BaseUrl değerini alır veya ayarlar.
/// </summary>
public string BaseUrl { get; set; } = "https://api.openai.com/v1/";
    }
}

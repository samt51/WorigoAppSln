namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
/// <summary>
/// CreateServiceRequestMessageCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestMessageCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// SenderUserId değerini alır veya ayarlar.
/// </summary>
public int? SenderUserId { get; set; }
/// <summary>
/// SenderType değerini alır veya ayarlar.
/// </summary>
public string SenderType { get; set; } = string.Empty;
/// <summary>
/// OriginalLanguageCode değerini alır veya ayarlar.
/// </summary>
public string OriginalLanguageCode { get; set; } = string.Empty;
/// <summary>
/// OriginalText değerini alır veya ayarlar.
/// </summary>
public string OriginalText { get; set; } = string.Empty;
/// <summary>
/// TranslatedLanguageCode değerini alır veya ayarlar.
/// </summary>
public string? TranslatedLanguageCode { get; set; }
/// <summary>
/// TranslatedText değerini alır veya ayarlar.
/// </summary>
public string? TranslatedText { get; set; }
/// <summary>
/// TranslationStatus değerini alır veya ayarlar.
/// </summary>
public string TranslationStatus { get; set; } = string.Empty;
/// <summary>
/// SentAt değerini alır veya ayarlar.
/// </summary>
public DateTime SentAt { get; set; }
    }
}

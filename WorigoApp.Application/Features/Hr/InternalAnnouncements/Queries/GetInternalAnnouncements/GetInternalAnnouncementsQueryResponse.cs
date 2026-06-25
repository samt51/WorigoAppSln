using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
/// <summary>
/// GetInternalAnnouncementsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetInternalAnnouncementsQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Content değerini alır veya ayarlar.
/// </summary>
public string Content { get; set; } = string.Empty;
/// <summary>
/// Audience değerini alır veya ayarlar.
/// </summary>
public InternalAnnouncementAudienceEnum Audience { get; set; }
/// <summary>
/// PublishAt değerini alır veya ayarlar.
/// </summary>
public DateTime PublishAt { get; set; }
/// <summary>
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
/// <summary>
/// IsPinned değerini alır veya ayarlar.
/// </summary>
public bool IsPinned { get; set; }
    }
}

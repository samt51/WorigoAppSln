using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Commands.CreateInternalAnnouncement
{
/// <summary>
/// CreateInternalAnnouncementCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateInternalAnnouncementCommandRequest : IRequest<ResponseDto<CreateInternalAnnouncementCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// CreatedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int CreatedByEmployeeId { get; set; }
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
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
/// <summary>
/// IsPinned değerini alır veya ayarlar.
/// </summary>
public bool IsPinned { get; set; }
    }
}

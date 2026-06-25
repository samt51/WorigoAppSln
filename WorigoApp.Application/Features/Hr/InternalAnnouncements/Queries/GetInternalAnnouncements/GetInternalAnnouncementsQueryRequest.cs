using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
/// <summary>
/// GetInternalAnnouncementsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetInternalAnnouncementsQueryRequest : IRequest<ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
    }
}

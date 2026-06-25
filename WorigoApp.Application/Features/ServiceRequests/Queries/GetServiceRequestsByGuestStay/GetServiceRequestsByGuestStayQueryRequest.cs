using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
/// <summary>
/// GetServiceRequestsByGuestStayQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByGuestStayQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
    }
}

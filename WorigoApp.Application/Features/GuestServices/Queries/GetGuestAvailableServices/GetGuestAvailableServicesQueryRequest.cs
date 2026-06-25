using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices
{
/// <summary>
/// GetGuestAvailableServicesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetGuestAvailableServicesQueryRequest : IRequest<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByHotel
{
/// <summary>
/// GetServiceRequestsByHotelQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByHotelQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum? Status { get; set; }
    }
}

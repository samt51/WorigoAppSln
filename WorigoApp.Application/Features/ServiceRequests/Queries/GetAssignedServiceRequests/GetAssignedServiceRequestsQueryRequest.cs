using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests
{
/// <summary>
/// GetAssignedServiceRequestsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAssignedServiceRequestsQueryRequest : IRequest<ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum? Status { get; set; }
    }
}

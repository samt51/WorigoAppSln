using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment
{
/// <summary>
/// GetServiceRequestsByDepartmentQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByDepartmentQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>>
    {
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum? Status { get; set; }
    }
}

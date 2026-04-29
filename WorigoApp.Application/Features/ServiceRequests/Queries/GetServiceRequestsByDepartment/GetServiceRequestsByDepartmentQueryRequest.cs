using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment
{
    public class GetServiceRequestsByDepartmentQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>>
    {
        public int DepartmentId { get; set; }
        public ServiceRequestStatusEnum? Status { get; set; }
    }
}

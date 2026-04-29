using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests
{
    public class GetAssignedServiceRequestsQueryRequest : IRequest<ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>>
    {
        public int EmployeeId { get; set; }
        public ServiceRequestStatusEnum? Status { get; set; }
    }
}

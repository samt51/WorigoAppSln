using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests
{
    public class GetAssignedServiceRequestsQueryHandler : BaseHandler, IRequestHandler<GetAssignedServiceRequestsQueryRequest, ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>>
    {
        public GetAssignedServiceRequestsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>> Handle(GetAssignedServiceRequestsQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.AssignedEmployeeId == request.EmployeeId &&
                     !x.IsDeleted &&
                     (!request.Status.HasValue || x.Status == request.Status.Value),
                orderBy: x => x.OrderBy(y => y.Status).ThenBy(y => y.DueAt).ThenByDescending(y => y.RequestedAt));

            var response = serviceRequests.Select(x => new GetAssignedServiceRequestsQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ServiceType = x.ServiceType,
                Status = x.Status,
                RoomId = x.RoomId,
                CustomerId = x.CustomerId,
                DepartmentId = x.DepartmentId,
                RequestedAt = x.RequestedAt,
                DueAt = x.DueAt
            }).ToList();

            return new ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>().Success(response);
        }
    }
}

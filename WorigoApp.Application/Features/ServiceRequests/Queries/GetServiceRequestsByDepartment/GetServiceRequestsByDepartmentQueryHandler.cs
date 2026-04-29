using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment
{
    public class GetServiceRequestsByDepartmentQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestsByDepartmentQueryRequest, ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>>
    {
        public GetServiceRequestsByDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>> Handle(GetServiceRequestsByDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.DepartmentId == request.DepartmentId &&
                     !x.IsDeleted &&
                     (!request.Status.HasValue || x.Status == request.Status.Value),
                orderBy: x => x.OrderBy(y => y.Status).ThenBy(y => y.DueAt).ThenByDescending(y => y.RequestedAt));

            var response = serviceRequests.Select(x => new GetServiceRequestsByDepartmentQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ServiceType = x.ServiceType,
                Status = x.Status,
                CustomerId = x.CustomerId,
                RoomId = x.RoomId,
                AssignedEmployeeId = x.AssignedEmployeeId,
                RequestedAt = x.RequestedAt,
                DueAt = x.DueAt,
                CompletedAt = x.CompletedAt
            }).ToList();

            return new ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>().Success(response);
        }
    }
}

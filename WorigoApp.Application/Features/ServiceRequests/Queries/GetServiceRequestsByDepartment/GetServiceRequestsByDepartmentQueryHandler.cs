using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
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
                include: query => query
                    .Include(x => x.ServiceDefinition)
                    .ThenInclude(x => x.ServiceCategory)
                    .Include(x => x.Items),
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
                ServiceDefinitionId = x.ServiceDefinitionId,
                ServiceDefinitionName = x.ServiceDefinition?.Name,
                ServiceCategoryId = x.ServiceDefinition?.ServiceCategoryId,
                ServiceCategoryName = x.ServiceDefinition?.ServiceCategory?.Name,
                ConversationId = x.ConversationId,
                RequestedAt = x.RequestedAt,
                DueAt = x.DueAt,
                CompletedAt = x.CompletedAt,
                Items = x.Items
                    .Where(item => !item.IsDeleted)
                    .Select(item => new ServiceRequestItemDto
                    {
                        ServiceDefinitionId = item.ServiceDefinitionId,
                        ItemName = item.ItemName,
                        Quantity = item.Quantity,
                        Note = item.Note
                    })
                    .ToList()
            }).ToList();

            return new ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>().Success(response);
        }
    }
}

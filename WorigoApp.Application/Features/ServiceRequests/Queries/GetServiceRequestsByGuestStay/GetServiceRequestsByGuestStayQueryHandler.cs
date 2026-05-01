using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay
{
    public class GetServiceRequestsByGuestStayQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestsByGuestStayQueryRequest, ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>>
    {
        public GetServiceRequestsByGuestStayQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>> Handle(GetServiceRequestsByGuestStayQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.GuestStayId == request.GuestStayId && !x.IsDeleted,
                include: query => query
                    .Include(x => x.ServiceDefinition)
                    .ThenInclude(x => x.ServiceCategory)
                    .Include(x => x.Items),
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = data.Select(x => new GetServiceRequestsByGuestStayQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ServiceType = x.ServiceType,
                Status = x.Status,
                LanguageCode = x.LanguageCode,
                RequestedAt = x.RequestedAt,
                CompletedAt = x.CompletedAt,
                AssignedEmployeeId = x.AssignedEmployeeId,
                DepartmentId = x.DepartmentId,
                ServiceDefinitionId = x.ServiceDefinitionId,
                ServiceDefinitionName = x.ServiceDefinition?.Name,
                ServiceCategoryId = x.ServiceDefinition?.ServiceCategoryId,
                ServiceCategoryName = x.ServiceDefinition?.ServiceCategory?.Name,
                ConversationId = x.ConversationId,
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

            return new ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>().Success(response);
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByHotel
{
/// <summary>
/// GetServiceRequestsByHotelQueryHandler sınıfını temsil eder.
/// </summary>
public class GetServiceRequestsByHotelQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestsByHotelQueryRequest, ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>>
    {
/// <summary>
/// GetServiceRequestsByHotelQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetServiceRequestsByHotelQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>> Handle(GetServiceRequestsByHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     (!request.Status.HasValue || x.Status == request.Status.Value),
                include: query => query
                    .Include(x => x.ServiceDefinition)
                    .ThenInclude(x => x.ServiceCategory)
                    .Include(x => x.Items),
                orderBy: x => x.OrderBy(y => y.Status).ThenBy(y => y.DueAt).ThenByDescending(y => y.RequestedAt));

            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync(
                d => d.HotelId == request.HotelId && !d.IsDeleted);

            var managerEmployeeIds = departments
                .Where(d => d.ManagerEmployeeId.HasValue)
                .Select(d => d.ManagerEmployeeId!.Value)
                .Distinct()
                .ToList();

            var managers = managerEmployeeIds.Any()
                ? await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                    e => managerEmployeeIds.Contains(e.Id) && !e.IsDeleted)
                : new List<Employee>();

            var managerMap = managers.ToDictionary(e => e.Id, e => $"{e.Name} {e.Surname}");
            var deptManagerMap = departments
                .Where(d => d.ManagerEmployeeId.HasValue)
                .ToDictionary(
                    d => d.Id, 
                    d => new { 
                        Id = d.ManagerEmployeeId!.Value, 
                        Name = managerMap.TryGetValue(d.ManagerEmployeeId!.Value, out var name) ? name : "Bilinmiyor" 
                    });

            var response = serviceRequests.Select(x => new GetServiceRequestsByHotelQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ServiceType = x.ServiceType,
                Status = x.Status,
                CustomerId = x.CustomerId,
                RoomId = x.RoomId,
                DepartmentId = x.DepartmentId,
                AssignedEmployeeId = x.AssignedEmployeeId,
                ServiceDefinitionId = x.ServiceDefinitionId,
                ServiceDefinitionName = x.ServiceDefinition?.Name,
                ServiceCategoryId = x.ServiceDefinition?.ServiceCategoryId,
                ServiceCategoryName = x.ServiceDefinition?.ServiceCategory?.Name,
                ConversationId = x.ConversationId,
                RequestedAt = x.RequestedAt,
                DueAt = x.DueAt,
                CompletedAt = x.CompletedAt,
                DepartmentManagerEmployeeId = x.DepartmentId.HasValue && deptManagerMap.TryGetValue(x.DepartmentId.Value, out var mInfo) ? mInfo.Id : null,
                DepartmentManagerName = x.DepartmentId.HasValue && deptManagerMap.TryGetValue(x.DepartmentId.Value, out var mInfo2) ? mInfo2.Name : null,
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

            return new ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>().Success(response);
        }
    }
}

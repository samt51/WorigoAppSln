using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel
{
/// <summary>
/// GetStockRequestsByHotelQueryHandler sınıfını temsil eder.
/// </summary>
public class GetStockRequestsByHotelQueryHandler : BaseHandler, IRequestHandler<GetStockRequestsByHotelQueryRequest, ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>>
    {
/// <summary>
/// GetStockRequestsByHotelQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetStockRequestsByHotelQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>> Handle(GetStockRequestsByHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var requests = await unitOfWork.GetReadRepository<StockRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x
                    .Include(y => y.RequestedByEmployee)
                    .Include(y => y.AssignedManagerEmployee)
                    .Include(y => y.Department)
                    .Include(y => y.Items),
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = requests.Select(x => new GetStockRequestsByHotelQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                RequestedByEmployeeName = $"{x.RequestedByEmployee.Name} {x.RequestedByEmployee.Surname}".Trim(),
                AssignedManagerEmployeeName = x.AssignedManagerEmployee is null ? null : $"{x.AssignedManagerEmployee.Name} {x.AssignedManagerEmployee.Surname}".Trim(),
                DepartmentName = x.Department?.Name,
                Priority = x.Priority,
                Status = x.Status,
                RequestedAt = x.RequestedAt,
                ItemCount = x.Items.Count
            }).ToList();

            return new ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>().Success(response);
        }
    }
}

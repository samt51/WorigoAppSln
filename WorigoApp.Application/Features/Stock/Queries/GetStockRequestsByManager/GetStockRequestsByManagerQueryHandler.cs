using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager
{
    public class GetStockRequestsByManagerQueryHandler : BaseHandler, IRequestHandler<GetStockRequestsByManagerQueryRequest, ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>>
    {
        public GetStockRequestsByManagerQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>> Handle(GetStockRequestsByManagerQueryRequest request, CancellationToken cancellationToken)
        {
            var requests = await unitOfWork.GetReadRepository<Domain.Entites.StockRequest>().GetAllAsync(
                x => x.AssignedManagerEmployeeId == request.ManagerEmployeeId && !x.IsDeleted,
                include: x => x
                    .Include(y => y.RequestedByEmployee)
                    .Include(y => y.Department),
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = requests.Select(x => new GetStockRequestsByManagerQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                RequestedByEmployeeName = $"{x.RequestedByEmployee.Name} {x.RequestedByEmployee.Surname}".Trim(),
                DepartmentName = x.Department?.Name,
                Priority = x.Priority,
                Status = x.Status,
                RequestedAt = x.RequestedAt,
                ManagerNote = x.ManagerNote
            }).ToList();

            return new ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>().Success(response);
        }
    }
}

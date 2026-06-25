using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport
{
/// <summary>
/// GetStockSummaryReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetStockSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetStockSummaryReportQueryRequest, ResponseDto<GetStockSummaryReportQueryResponse>>
    {
/// <summary>
/// GetStockSummaryReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetStockSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetStockSummaryReportQueryResponse>> Handle(GetStockSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetStockSummaryReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var stockItems = await unitOfWork.GetReadRepository<Domain.Entites.StockItem>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted);
            var stockRequests = await unitOfWork.GetReadRepository<Domain.Entites.StockRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted);

            var response = new GetStockSummaryReportQueryResponse
            {
                TotalStockItemCount = stockItems.Count,
                LowStockItemCount = stockItems.Count(x => x.CurrentQuantity <= x.MinimumQuantity),
                CriticalStockItemCount = stockItems.Count(x => x.IsCritical && x.CurrentQuantity <= x.MinimumQuantity),
                PendingStockRequestCount = stockRequests.Count(x => x.Status == StockRequestStatusEnum.Pending),
                TotalInventoryValue = stockItems.Sum(x => x.CurrentQuantity * x.AverageUnitCost)
            };

            return new ResponseDto<GetStockSummaryReportQueryResponse>().Success(response);
        }
    }
}

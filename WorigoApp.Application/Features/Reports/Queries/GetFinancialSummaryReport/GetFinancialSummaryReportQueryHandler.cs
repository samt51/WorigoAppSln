using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport
{
    public class GetFinancialSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetFinancialSummaryReportQueryRequest, ResponseDto<GetFinancialSummaryReportQueryResponse>>
    {
        public GetFinancialSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetFinancialSummaryReportQueryResponse>> Handle(GetFinancialSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            var startDate = request.StartDate ?? DateTime.MinValue;
            var endDate = request.EndDate ?? DateTime.MaxValue;

            var orders = await unitOfWork.GetReadRepository<Order>().GetAllAsync(
                x => !x.IsDeleted &&
                     x.GuestStay.HotelId == request.HotelId &&
                     x.CreatedDate >= startDate &&
                     x.CreatedDate <= endDate,
                include: x => x.Include(y => y.OrderItems));

            var purchaseMovements = await unitOfWork.GetReadRepository<StockMovement>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     x.MovementType == StockMovementTypeEnum.PurchaseIn &&
                     x.OccurredAt >= startDate &&
                     x.OccurredAt <= endDate);

            var completedRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     (x.Status == ServiceRequestStatusEnum.Completed || x.Status == ServiceRequestStatusEnum.Closed) &&
                     x.RequestedAt >= startDate &&
                     x.RequestedAt <= endDate,
                include: x => x.Include(y => y.Ratings));

            var totalRevenue = orders.Sum(x => x.TotalPrice);
            var totalPurchaseCost = purchaseMovements.Sum(x => x.TotalAmount);
            var ratings = completedRequests.SelectMany(x => x.Ratings).ToList();

            var response = new GetFinancialSummaryReportQueryResponse
            {
                TotalRevenue = totalRevenue,
                TotalPurchaseCost = totalPurchaseCost,
                GrossProfit = totalRevenue - totalPurchaseCost,
                TotalOrderCount = orders.Count,
                TotalOrderItemCount = orders.SelectMany(x => x.OrderItems).Count(),
                AverageOrderValue = orders.Count == 0 ? 0 : orders.Average(x => x.TotalPrice),
                CompletedServiceRequestCount = completedRequests.Count,
                AverageServiceRating = ratings.Count == 0 ? 0 : ratings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m)
            };

            return new ResponseDto<GetFinancialSummaryReportQueryResponse>().Success(response);
        }
    }
}

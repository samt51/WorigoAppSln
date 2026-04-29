using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport
{
    public class GetDepartmentPerformanceReportQueryHandler : BaseHandler, IRequestHandler<GetDepartmentPerformanceReportQueryRequest, ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>>
    {
        public GetDepartmentPerformanceReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>> Handle(GetDepartmentPerformanceReportQueryRequest request, CancellationToken cancellationToken)
        {
            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);
            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.Ratings));
            var stockRequests = await unitOfWork.GetReadRepository<StockRequest>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);
            var stockItems = await unitOfWork.GetReadRepository<StockItem>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);

            var response = departments.Select(department =>
            {
                var departmentRequests = serviceRequests.Where(x => x.DepartmentId == department.Id).ToList();
                var completedRequests = departmentRequests.Where(x => x.Status == ServiceRequestStatusEnum.Completed || x.Status == ServiceRequestStatusEnum.Closed).ToList();
                var resolutionMinutes = completedRequests
                    .Where(x => x.AssignedAt.HasValue && x.CompletedAt.HasValue)
                    .Select(x => (decimal)(x.CompletedAt.Value - x.AssignedAt.Value).TotalMinutes)
                    .ToList();
                var ratings = departmentRequests.SelectMany(x => x.Ratings).ToList();

                return new GetDepartmentPerformanceReportQueryResponse
                {
                    DepartmentId = department.Id,
                    DepartmentName = department.Name,
                    TotalRequestCount = departmentRequests.Count,
                    OpenRequestCount = departmentRequests.Count(x => x.Status != ServiceRequestStatusEnum.Completed && x.Status != ServiceRequestStatusEnum.Closed),
                    CompletedRequestCount = completedRequests.Count,
                    AverageResolutionMinutes = resolutionMinutes.Count == 0 ? 0 : resolutionMinutes.Average(),
                    AverageRating = ratings.Count == 0 ? 0 : ratings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m),
                    PendingStockRequestCount = stockRequests.Count(x => x.DepartmentId == department.Id && x.Status == StockRequestStatusEnum.Pending),
                    LowStockItemCount = stockItems.Count(x => x.DepartmentId == department.Id && x.CurrentQuantity <= x.MinimumQuantity)
                };
            }).OrderByDescending(x => x.TotalRequestCount).ToList();

            return new ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>().Success(response);
        }
    }
}

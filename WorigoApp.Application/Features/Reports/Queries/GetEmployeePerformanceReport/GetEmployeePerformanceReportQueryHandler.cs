using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport
{
/// <summary>
/// GetEmployeePerformanceReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetEmployeePerformanceReportQueryHandler : BaseHandler, IRequestHandler<GetEmployeePerformanceReportQueryRequest, ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>>
    {
/// <summary>
/// GetEmployeePerformanceReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetEmployeePerformanceReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>> Handle(GetEmployeePerformanceReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var employees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.EmployeeType));

            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.Ratings));

            var stockRequests = await unitOfWork.GetReadRepository<StockRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted);

            var response = employees.Select(employee =>
            {
                var employeeRequests = serviceRequests.Where(x => x.AssignedEmployeeId == employee.Id).ToList();
                var completedRequests = employeeRequests.Where(x => x.Status == ServiceRequestStatusEnum.Completed || x.Status == ServiceRequestStatusEnum.Closed).ToList();
                var resolutionMinutes = completedRequests
                    .Where(x => x.AssignedAt.HasValue && x.CompletedAt.HasValue)
                    .Select(x => (decimal)(x.CompletedAt.Value - x.AssignedAt.Value).TotalMinutes)
                    .ToList();
                var ratings = employeeRequests.SelectMany(x => x.Ratings).ToList();

                return new GetEmployeePerformanceReportQueryResponse
                {
                    EmployeeId = employee.Id,
                    EmployeeName = $"{employee.Name} {employee.Surname}".Trim(),
                    EmployeeTypeName = employee.EmployeeType?.Name,
                    TotalAssignedRequestCount = employeeRequests.Count,
                    CompletedRequestCount = completedRequests.Count,
                    CompletionRate = employeeRequests.Count == 0 ? 0 : (decimal)completedRequests.Count / employeeRequests.Count * 100m,
                    AverageResolutionMinutes = resolutionMinutes.Count == 0 ? 0 : resolutionMinutes.Average(),
                    AverageRating = ratings.Count == 0 ? employee.AverageRating : ratings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m),
                    CreatedStockRequestCount = stockRequests.Count(x => x.RequestedByEmployeeId == employee.Id)
                };
            }).OrderByDescending(x => x.CompletedRequestCount).ToList();

            return new ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>().Success(response);
        }
    }
}

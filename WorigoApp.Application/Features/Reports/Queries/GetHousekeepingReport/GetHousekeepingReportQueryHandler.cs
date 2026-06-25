using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetHousekeepingReport
{
/// <summary>
/// GetHousekeepingReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetHousekeepingReportQueryHandler : BaseHandler, IRequestHandler<GetHousekeepingReportQueryRequest, ResponseDto<GetHousekeepingReportQueryResponse>>
    {
/// <summary>
/// GetHousekeepingReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetHousekeepingReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetHousekeepingReportQueryResponse>> Handle(GetHousekeepingReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetHousekeepingReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var startDate = request.StartDate ?? DateTime.MinValue;
            var endDate = request.EndDate ?? DateTime.MaxValue;

            var tasks = await unitOfWork.GetReadRepository<EmployeeTask>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     x.DepartmentId == 2 &&
                     !x.IsDeleted &&
                     x.CreatedDate >= startDate &&
                     x.CreatedDate <= endDate,
                include: q => q.Include(x => x.AssignedEmployee));

            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     x.DepartmentId == 2 &&
                     !x.IsDeleted &&
                     x.RequestedAt >= startDate &&
                     x.RequestedAt <= endDate,
                include: q => q.Include(x => x.Ratings));

            var totalTasksCount = tasks.Count;
            var completedTasksCount = tasks.Count(x => x.Status == EmployeeTaskStatusEnum.Completed);
            var taskCompletionRate = totalTasksCount == 0 ? 0 : Math.Round((decimal)completedTasksCount / totalTasksCount * 100m, 2);

            var cleaningDurations = tasks
                .Where(x => x.Status == EmployeeTaskStatusEnum.Completed && x.StartedAt.HasValue && x.CompletedAt.HasValue)
                .Select(x => (decimal)(x.CompletedAt.Value - x.StartedAt.Value).TotalMinutes)
                .ToList();
            var averageCleaningTimeMinutes = cleaningDurations.Count == 0 ? 0 : Math.Round(cleaningDurations.Average(), 2);

            var totalServiceRequestsCount = serviceRequests.Count;
            var completedServiceRequestsCount = serviceRequests.Count(x => x.Status == ServiceRequestStatusEnum.Completed || x.Status == ServiceRequestStatusEnum.Closed);
            var ratings = serviceRequests.SelectMany(x => x.Ratings).ToList();
            var averageServiceRequestRating = ratings.Count == 0 ? 0 : Math.Round(ratings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m), 2);

            var housekeeperPerformance = tasks
                .GroupBy(x => x.AssignedEmployeeId)
                .Select(g =>
                {
                    var emp = g.FirstOrDefault()?.AssignedEmployee;
                    var empName = emp != null ? $"{emp.Name} {emp.Surname}".Trim() : $"Personel #{g.Key}";
                    var empTasks = g.ToList();
                    var empCompleted = empTasks.Count(x => x.Status == EmployeeTaskStatusEnum.Completed);
                    var empDurations = empTasks
                        .Where(x => x.Status == EmployeeTaskStatusEnum.Completed && x.StartedAt.HasValue && x.CompletedAt.HasValue)
                        .Select(x => (decimal)(x.CompletedAt.Value - x.StartedAt.Value).TotalMinutes)
                        .ToList();
                    var empAvgTime = empDurations.Count == 0 ? 0 : Math.Round(empDurations.Average(), 2);

                    return new HousekeeperPerformanceDto
                    {
                        EmployeeId = g.Key,
                        EmployeeName = empName,
                        AssignedTasksCount = empTasks.Count,
                        CompletedTasksCount = empCompleted,
                        AverageCleaningTimeMinutes = empAvgTime
                    };
                })
                .OrderByDescending(x => x.CompletedTasksCount)
                .ToList();

            var response = new GetHousekeepingReportQueryResponse
            {
                TotalTasksCount = totalTasksCount,
                CompletedTasksCount = completedTasksCount,
                TaskCompletionRate = taskCompletionRate,
                AverageCleaningTimeMinutes = averageCleaningTimeMinutes,
                TotalServiceRequestsCount = totalServiceRequestsCount,
                CompletedServiceRequestsCount = completedServiceRequestsCount,
                AverageServiceRequestRating = averageServiceRequestRating,
                HousekeeperPerformance = housekeeperPerformance
            };

            return new ResponseDto<GetHousekeepingReportQueryResponse>().Success(response);
        }
    }
}

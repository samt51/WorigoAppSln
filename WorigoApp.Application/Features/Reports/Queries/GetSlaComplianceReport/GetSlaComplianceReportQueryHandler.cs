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

namespace WorigoApp.Application.Features.Reports.Queries.GetSlaComplianceReport
{
/// <summary>
/// GetSlaComplianceReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetSlaComplianceReportQueryHandler : BaseHandler, IRequestHandler<GetSlaComplianceReportQueryRequest, ResponseDto<GetSlaComplianceReportQueryResponse>>
    {
/// <summary>
/// GetSlaComplianceReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetSlaComplianceReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetSlaComplianceReportQueryResponse>> Handle(GetSlaComplianceReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetSlaComplianceReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var startDate = request.StartDate ?? DateTime.MinValue;
            var endDate = request.EndDate ?? DateTime.MaxValue;

            // Fetch service requests using AsNoTracking via enableTracking: false
            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     (!request.DepartmentId.HasValue || x.DepartmentId == request.DepartmentId.Value) &&
                     !x.IsDeleted &&
                     x.RequestedAt >= startDate &&
                     x.RequestedAt <= endDate,
                include: q => q.Include(r => r.ServiceDefinition!)
                               .Include(r => r.Department!),
                enableTracking: false
            );

            int totalCount = 0;
            int compliantCount = 0;
            int breachedCount = 0;

            double totalResponseMinutes = 0;
            int responseCount = 0;

            double totalResolutionMinutes = 0;
            int resolutionCount = 0;

            // Priority lists
            var priorityStats = new Dictionary<ServiceRequestPriorityEnum, (int Total, int Breached)>();
            foreach (ServiceRequestPriorityEnum p in Enum.GetValues(typeof(ServiceRequestPriorityEnum)))
            {
                priorityStats[p] = (0, 0);
            }

            // Department lists
            var deptStats = new Dictionary<int, (string Name, int Total, int Breached, double TotalRespMin, int RespCount, double TotalResMin, int ResCount)>();

            // Service details for top breaches
            var serviceBreaches = new Dictionary<string, (int Breaches, double TotalBreachMin)>();

            foreach (var req in serviceRequests)
            {
                // Guard clause: basic sanitization
                if (req.RequestedAt == DateTime.MinValue) continue;

                totalCount++;

                // 1. Target SLA deadline calculation
                DateTime deadline;
                if (req.DueAt.HasValue && req.DueAt.Value >= req.RequestedAt)
                {
                    deadline = req.DueAt.Value;
                }
                else if (req.ServiceDefinition != null && req.ServiceDefinition.EstimatedDurationMinutes.HasValue && req.ServiceDefinition.EstimatedDurationMinutes.Value > 0)
                {
                    deadline = req.RequestedAt.AddMinutes(req.ServiceDefinition.EstimatedDurationMinutes.Value);
                }
                else
                {
                    // Fallbacks based on Priority
                    int defaultMinutes = req.Priority switch
                    {
                        ServiceRequestPriorityEnum.Critical => 30,
                        ServiceRequestPriorityEnum.High => 60,
                        ServiceRequestPriorityEnum.Normal => 180,
                        ServiceRequestPriorityEnum.Low => 360,
                        _ => 180
                    };
                    deadline = req.RequestedAt.AddMinutes(defaultMinutes);
                }

                // 2. SLA breach check
                bool isBreached = false;
                double breachMinutes = 0;

                if (req.Status == ServiceRequestStatusEnum.Completed || req.Status == ServiceRequestStatusEnum.Closed || req.CompletedAt.HasValue)
                {
                    var compAt = req.CompletedAt ?? DateTime.UtcNow;
                    // Guard clause: check for date anomalies (e.g. CompletedAt < RequestedAt)
                    if (compAt >= req.RequestedAt)
                    {
                        if (compAt > deadline)
                        {
                            isBreached = true;
                            breachMinutes = (compAt - deadline).TotalMinutes;
                        }
                    }
                }
                else
                {
                    // If not completed yet, checking against current time
                    var now = DateTime.UtcNow;
                    if (now > deadline)
                    {
                        isBreached = true;
                        breachMinutes = (now - deadline).TotalMinutes;
                    }
                }

                // Ensure breachMinutes is not negative
                if (breachMinutes < 0) breachMinutes = 0;

                if (isBreached)
                {
                    breachedCount++;
                }
                else
                {
                    compliantCount++;
                }

                // 3. Response time calculation
                // Priority of response timestamp: FirstResponseAt (if any, but since it doesn't exist, we use AssignedAt or StartedAt or CompletedAt)
                DateTime? responseTimeVal = req.StartedAt ?? req.AssignedAt ?? req.CompletedAt;
                if (responseTimeVal.HasValue)
                {
                    var respVal = responseTimeVal.Value;
                    // Guard Clause: prevent negative duration
                    if (respVal >= req.RequestedAt)
                    {
                        var respMin = (respVal - req.RequestedAt).TotalMinutes;
                        totalResponseMinutes += respMin;
                        responseCount++;

                        // Add to department response stats
                        if (req.DepartmentId.HasValue)
                        {
                            var depId = req.DepartmentId.Value;
                            var depName = req.Department?.Name ?? "Tanımsız Departman";
                            if (!deptStats.ContainsKey(depId))
                            {
                                deptStats[depId] = (depName, 0, 0, 0, 0, 0, 0);
                            }
                            var current = deptStats[depId];
                            deptStats[depId] = (current.Name, current.Total, current.Breached, current.TotalRespMin + respMin, current.RespCount + 1, current.TotalResMin, current.ResCount);
                        }
                    }
                }

                // 4. Resolution time calculation
                if (req.CompletedAt.HasValue)
                {
                    var compVal = req.CompletedAt.Value;
                    // Guard Clause: prevent negative duration
                    if (compVal >= req.RequestedAt)
                    {
                        var resMin = (compVal - req.RequestedAt).TotalMinutes;
                        totalResolutionMinutes += resMin;
                        resolutionCount++;

                        // Add to department resolution stats
                        if (req.DepartmentId.HasValue)
                        {
                            var depId = req.DepartmentId.Value;
                            var depName = req.Department?.Name ?? "Tanımsız Departman";
                            if (!deptStats.ContainsKey(depId))
                            {
                                deptStats[depId] = (depName, 0, 0, 0, 0, 0, 0);
                            }
                            var current = deptStats[depId];
                            deptStats[depId] = (current.Name, current.Total, current.Breached, current.TotalRespMin, current.RespCount, current.TotalResMin + resMin, current.ResCount + 1);
                        }
                    }
                }

                // 5. Aggregate priority stats
                var currentPriority = req.Priority;
                var currentPStats = priorityStats[currentPriority];
                priorityStats[currentPriority] = (currentPStats.Total + 1, currentPStats.Breached + (isBreached ? 1 : 0));

                // 6. Aggregate department stats
                if (req.DepartmentId.HasValue)
                {
                    var depId = req.DepartmentId.Value;
                    var depName = req.Department?.Name ?? "Tanımsız Departman";
                    if (!deptStats.ContainsKey(depId))
                    {
                        deptStats[depId] = (depName, 0, 0, 0, 0, 0, 0);
                    }
                    var current = deptStats[depId];
                    deptStats[depId] = (current.Name, current.Total + 1, current.Breached + (isBreached ? 1 : 0), current.TotalRespMin, current.RespCount, current.TotalResMin, current.ResCount);
                }

                // 7. Track top breaching services
                if (isBreached)
                {
                    var serviceName = req.ServiceDefinition?.Name ?? req.Title ?? "Diğer Servis";
                    if (!serviceBreaches.ContainsKey(serviceName))
                    {
                        serviceBreaches[serviceName] = (0, 0);
                    }
                    var currentS = serviceBreaches[serviceName];
                    serviceBreaches[serviceName] = (currentS.Breaches + 1, currentS.TotalBreachMin + breachMinutes);
                }
            }

            // Map stats to Response model
            var priorityList = priorityStats.Select(x => new SlaPriorityComplianceDto
            {
                Priority = x.Key.ToString(),
                TotalRequests = x.Value.Total,
                BreachedRequests = x.Value.Breached,
                ComplianceRate = x.Value.Total == 0 ? 100m : Math.Round((decimal)(x.Value.Total - x.Value.Breached) / x.Value.Total * 100m, 2)
            }).ToList();

            var departmentList = deptStats.Select(x => new SlaDepartmentComplianceDto
            {
                DepartmentId = x.Key,
                DepartmentName = x.Value.Name,
                TotalRequests = x.Value.Total,
                BreachedRequests = x.Value.Breached,
                ComplianceRate = x.Value.Total == 0 ? 100m : Math.Round((decimal)(x.Value.Total - x.Value.Breached) / x.Value.Total * 100m, 2),
                AverageResponseMinutes = x.Value.RespCount == 0 ? 0m : Math.Round((decimal)(x.Value.TotalRespMin / x.Value.RespCount), 2),
                AverageResolutionMinutes = x.Value.ResCount == 0 ? 0m : Math.Round((decimal)(x.Value.TotalResMin / x.Value.ResCount), 2)
            }).ToList();

            var topBreachingList = serviceBreaches.Select(x => new SlaTopBreachedServiceDto
            {
                ServiceName = x.Key,
                BreachCount = x.Value.Breaches,
                AverageBreachMinutes = x.Value.Breaches == 0 ? 0m : Math.Round((decimal)(x.Value.TotalBreachMin / x.Value.Breaches), 2)
            }).OrderByDescending(x => x.BreachCount).Take(5).ToList();

            decimal overallCompliance = totalCount == 0 ? 100m : Math.Round((decimal)(totalCount - breachedCount) / totalCount * 100m, 2);
            decimal avgResponse = responseCount == 0 ? 0m : Math.Round((decimal)(totalResponseMinutes / responseCount), 2);
            decimal avgResolution = resolutionCount == 0 ? 0m : Math.Round((decimal)(totalResolutionMinutes / resolutionCount), 2);

            var result = new GetSlaComplianceReportQueryResponse
            {
                TotalRequestCount = totalCount,
                CompliantRequestCount = compliantCount,
                BreachedRequestCount = breachedCount,
                SlaComplianceRate = overallCompliance,
                AverageResponseMinutes = avgResponse,
                AverageResolutionMinutes = avgResolution,
                IsEstimatedResponseTime = true, // We are estimating from AssignedAt/StartedAt/CompletedAt since there's no real FirstResponseAt
                SlaComplianceByPriority = priorityList,
                SlaComplianceByDepartment = departmentList,
                TopBreachingServices = topBreachingList
            };

            return new ResponseDto<GetSlaComplianceReportQueryResponse>().Success(result);
        }
    }
}

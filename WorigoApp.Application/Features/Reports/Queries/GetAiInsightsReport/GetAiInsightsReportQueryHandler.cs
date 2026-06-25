using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport;
using WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport;
using WorigoApp.Application.Features.Reports.Queries.GetHousekeepingReport;
using WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetSlaComplianceReport;

namespace WorigoApp.Application.Features.Reports.Queries.GetAiInsightsReport
{
/// <summary>
/// GetAiInsightsReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAiInsightsReportQueryHandler : BaseHandler, IRequestHandler<GetAiInsightsReportQueryRequest, ResponseDto<GetAiInsightsReportQueryResponse>>
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
 /// <summary>
 /// GetAiInsightsReportQueryHandler sınıfının yeni bir örneğini başlatır.
 /// </summary>

        public GetAiInsightsReportQueryHandler(
            IMapper mapper, 
            IUnitOfWork unitOfWork, 
            IMediator mediator, 
            IConfiguration configuration,
            IHttpClientFactory httpClientFactory) : base(mapper, unitOfWork)
        {
            _mediator = mediator;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetAiInsightsReportQueryResponse>> Handle(GetAiInsightsReportQueryRequest request, CancellationToken cancellationToken)
        {
            // 1. Tenant Security Enforcement (SystemAdmin also undergoes this check)
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetAiInsightsReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var startDate = request.StartDate ?? DateTime.Today.AddDays(-7);
            var endDate = request.EndDate ?? DateTime.Today;

            // 2. Fetch Logged-In User Details with Role and Employee Department details
            var user = await unitOfWork.GetReadRepository<Users>().GetAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(u => u.Employee!)
                               .ThenInclude(e => e.EmployeeType!)
                               .ThenInclude(et => et.Department!),
                enableTracking: false
            );

            if (user == null)
            {
                return new ResponseDto<GetAiInsightsReportQueryResponse>().Fail("Kullanıcı bulunamadı.", 404);
            }

            // 3. Resolve User Insight Scope and Enforce Access Rules
            string insightScope = string.Empty;
            string roleBasedMessage = string.Empty;
            int? userDepartmentId = null;
            string? userDepartmentName = null;

            if (user.RoleId == 1 || user.RoleId == 2)
            {
                insightScope = "FullHotel";
                roleBasedMessage = "Tüm otel verileri ve stratejik yönetim analizleri yüklenmiştir.";
            }
            else if (user.RoleId == 3)
            {
                insightScope = "Operations";
                roleBasedMessage = "Tüm operasyonel veriler ve günlük aksiyon önerileri yüklenmiştir.";
            }
            else if (user.RoleId == 4)
            {
                insightScope = "Department";
                userDepartmentId = user.Employee?.EmployeeType?.DepartmentId;
                userDepartmentName = user.Employee?.EmployeeType?.Department?.Name;

                if (userDepartmentId == null || userDepartmentId == 0)
                {
                    return new ResponseDto<GetAiInsightsReportQueryResponse>().Fail("Departman müdürü için departman bilgisi bulunamadı.", 403);
                }
                roleBasedMessage = $"{userDepartmentName} departmanına özel veriler ve departman aksiyon önerileri yüklenmiştir.";
            }
            else
            {
                // Forbidden Roles: Employee (5), Customer (6), HRManager (7), PurchasingManager (8)
                return new ResponseDto<GetAiInsightsReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            // 4. Fetch Scoped Reports based on Role Scope
            GetOccupancyReportQueryResponse occupancy = null;
            GetFoodSalesReportQueryResponse foodSales = null;
            GetHousekeepingReportQueryResponse housekeeping = null;
            GetFinancialSummaryReportQueryResponse financial = null;
            GetSlaComplianceReportQueryResponse sla = null;

            // Variables for Department Manager calculations
            int deptTotalRequests = 0;
            int deptCompliantRequests = 0;
            int deptBreachedRequests = 0;
            decimal deptSlaComplianceRate = 100m;
            decimal deptAvgResponse = 0m;
            decimal deptAvgResolution = 0m;
            decimal deptAvgRating = 0m;
            int deptTotalTasks = 0;
            int deptCompletedTasks = 0;
            int deptOpenTasks = 0;
            int deptOverdueTasks = 0;
            int deptPendingStockRequests = 0;

            if (insightScope == "FullHotel")
            {
                var occupancyTask = _mediator.Send(new GetOccupancyReportQueryRequest { HotelId = request.HotelId, Date = endDate }, cancellationToken);
                var foodSalesTask = _mediator.Send(new GetFoodSalesReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);
                var housekeepingTask = _mediator.Send(new GetHousekeepingReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);
                var financialTask = _mediator.Send(new GetFinancialSummaryReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);
                var slaTask = _mediator.Send(new GetSlaComplianceReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);

                await Task.WhenAll(occupancyTask, foodSalesTask, housekeepingTask, financialTask, slaTask);

                occupancy = occupancyTask.Result?.Data;
                foodSales = foodSalesTask.Result?.Data;
                housekeeping = housekeepingTask.Result?.Data;
                financial = financialTask.Result?.Data;
                sla = slaTask.Result?.Data;
            }
            else if (insightScope == "Operations")
            {
                var occupancyTask = _mediator.Send(new GetOccupancyReportQueryRequest { HotelId = request.HotelId, Date = endDate }, cancellationToken);
                var housekeepingTask = _mediator.Send(new GetHousekeepingReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);
                var slaTask = _mediator.Send(new GetSlaComplianceReportQueryRequest { HotelId = request.HotelId, StartDate = startDate, EndDate = endDate }, cancellationToken);

                await Task.WhenAll(occupancyTask, housekeepingTask, slaTask);

                occupancy = occupancyTask.Result?.Data;
                housekeeping = housekeepingTask.Result?.Data;
                sla = slaTask.Result?.Data;
            }
            else if (insightScope == "Department")
            {
                // Department Scope: Query only own Department requests, tasks and stock requests using HotelId & DepartmentId filters.
                var deptRequests = await unitOfWork.GetReadRepository<ServiceRequest>().GetAllAsync(
                    x => x.HotelId == request.HotelId && 
                         x.DepartmentId == userDepartmentId.Value && 
                         !x.IsDeleted && 
                         x.RequestedAt >= startDate && 
                         x.RequestedAt <= endDate,
                    include: q => q.Include(r => r.ServiceDefinition!)
                                   .Include(r => r.Ratings),
                    enableTracking: false
                );

                var deptTasks = await unitOfWork.GetReadRepository<EmployeeTask>().GetAllAsync(
                    x => x.HotelId == request.HotelId && 
                         x.DepartmentId == userDepartmentId.Value && 
                         !x.IsDeleted && 
                         x.CreatedDate >= startDate && 
                         x.CreatedDate <= endDate,
                    enableTracking: false
                );

                var deptStockRequests = await unitOfWork.GetReadRepository<StockRequest>().GetAllAsync(
                    x => x.HotelId == request.HotelId && 
                         x.DepartmentId == userDepartmentId.Value && 
                         !x.IsDeleted && 
                         x.RequestedAt >= startDate && 
                         x.RequestedAt <= endDate,
                    enableTracking: false
                );

                // Department stats calculation
                deptTotalRequests = deptRequests.Count;
                double totalResponseMinutes = 0;
                int responseCount = 0;
                double totalResolutionMinutes = 0;
                int resolutionCount = 0;

                foreach (var req in deptRequests)
                {
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

                    bool isBreached = false;
                    if (req.Status == ServiceRequestStatusEnum.Completed || req.Status == ServiceRequestStatusEnum.Closed || req.CompletedAt.HasValue)
                    {
                        var compAt = req.CompletedAt ?? DateTime.UtcNow;
                        if (compAt >= req.RequestedAt && compAt > deadline)
                        {
                            isBreached = true;
                        }
                    }
                    else
                    {
                        var now = DateTime.UtcNow;
                        if (now > deadline)
                        {
                            isBreached = true;
                        }
                    }

                    if (isBreached) deptBreachedRequests++;
                    else deptCompliantRequests++;

                    DateTime? responseTimeVal = req.StartedAt ?? req.AssignedAt ?? req.CompletedAt;
                    if (responseTimeVal.HasValue && responseTimeVal.Value >= req.RequestedAt)
                    {
                        totalResponseMinutes += (responseTimeVal.Value - req.RequestedAt).TotalMinutes;
                        responseCount++;
                    }

                    if (req.CompletedAt.HasValue && req.CompletedAt.Value >= req.RequestedAt)
                    {
                        totalResolutionMinutes += (req.CompletedAt.Value - req.RequestedAt).TotalMinutes;
                        resolutionCount++;
                    }
                }

                deptSlaComplianceRate = deptTotalRequests == 0 ? 100m : Math.Round((decimal)(deptTotalRequests - deptBreachedRequests) / deptTotalRequests * 100m, 2);
                deptAvgResponse = responseCount == 0 ? 0m : Math.Round((decimal)(totalResponseMinutes / responseCount), 2);
                deptAvgResolution = resolutionCount == 0 ? 0m : Math.Round((decimal)(totalResolutionMinutes / resolutionCount), 2);

                var ratings = deptRequests.SelectMany(x => x.Ratings).ToList();
                deptAvgRating = ratings.Count == 0 ? 0m : Math.Round(ratings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m), 2);

                deptTotalTasks = deptTasks.Count;
                deptCompletedTasks = deptTasks.Count(x => x.Status == EmployeeTaskStatusEnum.Completed);
                deptOpenTasks = deptTasks.Count(x => x.Status == EmployeeTaskStatusEnum.Open || x.Status == EmployeeTaskStatusEnum.InProgress);
                deptOverdueTasks = deptTasks.Count(x => x.Status != EmployeeTaskStatusEnum.Completed && x.DueAt.HasValue && DateTime.UtcNow > x.DueAt.Value);
                deptPendingStockRequests = deptStockRequests.Count(x => x.Status == StockRequestStatusEnum.Pending);
            }

            // 5. Resolve API Configurations
            var apiKey = _configuration["Gemini:ApiKey"];
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                apiKey = Environment.GetEnvironmentVariable("Gemini_ApiKey") 
                         ?? Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            }

            var modelName = _configuration["Gemini:ModelName"];
            if (string.IsNullOrWhiteSpace(modelName))
            {
                modelName = "gemini-2.5-flash";
            }

            bool apiCallSuccessful = false;
            GetAiInsightsReportQueryResponse responseData = null;

            if (!string.IsNullOrWhiteSpace(apiKey))
            {
                try
                {
                    // Build context without PII (strictly aggregated metrics)
                    object statsContext;
                    string prompt;

                    if (insightScope == "FullHotel")
                    {
                        statsContext = new
                        {
                            DateRange = $"{startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}",
                            Occupancy = new
                            {
                                TotalRooms = occupancy?.TotalRoomCount ?? 0,
                                OccupiedRooms = occupancy?.OccupiedRoomCount ?? 0,
                                OccupancyRate = occupancy?.OccupancyRate ?? 0,
                                CleanRooms = occupancy?.CleanRoomCount ?? 0,
                                DirtyRooms = occupancy?.DirtyRoomCount ?? 0,
                                OutOrOrderRooms = occupancy?.OutOfOrderRoomCount ?? 0,
                                ExpectedArrivals = occupancy?.ExpectedArrivalsCount ?? 0,
                                ExpectedDepartures = occupancy?.ExpectedDeparturesCount ?? 0,
                                VipGuests = occupancy?.VIPGuestsCount ?? 0
                            },
                            FoodSales = new
                            {
                                TotalOrders = foodSales?.TotalOrdersCount ?? 0,
                                TotalRevenue = foodSales?.TotalRevenue ?? 0,
                                AverageOrderValue = foodSales?.AverageOrderValue ?? 0,
                                TopItems = foodSales?.TopSellingItems?.Select(x => $"{x.ItemName} ({x.Quantity} adet, {x.Revenue} TRY)")?.ToList() ?? new List<string>()
                            },
                            Housekeeping = new
                            {
                                TotalDuties = housekeeping?.TotalTasksCount ?? 0,
                                CompletedDuties = housekeeping?.CompletedTasksCount ?? 0,
                                CompletionRate = housekeeping?.TaskCompletionRate ?? 0,
                                AverageCleaningMinutes = housekeeping?.AverageCleaningTimeMinutes ?? 0,
                                AverageGuestRating = housekeeping?.AverageServiceRequestRating ?? 0
                            },
                            Financials = new
                            {
                                Revenue = financial?.TotalRevenue ?? 0,
                                Cost = financial?.TotalPurchaseCost ?? 0,
                                GrossProfit = financial?.GrossProfit ?? 0,
                                TotalOrders = financial?.TotalOrderCount ?? 0
                            },
                            SlaKpis = new
                            {
                                TotalRequests = sla?.TotalRequestCount ?? 0,
                                CompliantRequests = sla?.CompliantRequestCount ?? 0,
                                BreachedRequests = sla?.BreachedRequestCount ?? 0,
                                SlaComplianceRate = sla?.SlaComplianceRate ?? 0,
                                AverageResponseMinutes = sla?.AverageResponseMinutes ?? 0,
                                AverageResolutionMinutes = sla?.AverageResolutionMinutes ?? 0,
                                TopBreachingServices = sla?.TopBreachingServices?.Select(x => $"{x.ServiceName} ({x.BreachCount} ihlal)")?.ToList() ?? new List<string>()
                            }
                        };
                        prompt = BuildOwnerInsightPrompt(statsContext);
                    }
                    else if (insightScope == "Operations")
                    {
                        statsContext = new
                        {
                            DateRange = $"{startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}",
                            Occupancy = new
                            {
                                TotalRooms = occupancy?.TotalRoomCount ?? 0,
                                OccupiedRooms = occupancy?.OccupiedRoomCount ?? 0,
                                OccupancyRate = occupancy?.OccupancyRate ?? 0,
                                CleanRooms = occupancy?.CleanRoomCount ?? 0,
                                DirtyRooms = occupancy?.DirtyRoomCount ?? 0,
                                OutOrOrderRooms = occupancy?.OutOfOrderRoomCount ?? 0,
                                ExpectedArrivals = occupancy?.ExpectedArrivalsCount ?? 0,
                                ExpectedDepartures = occupancy?.ExpectedDeparturesCount ?? 0,
                                VipGuests = occupancy?.VIPGuestsCount ?? 0
                            },
                            Housekeeping = new
                            {
                                TotalDuties = housekeeping?.TotalTasksCount ?? 0,
                                CompletedDuties = housekeeping?.CompletedTasksCount ?? 0,
                                CompletionRate = housekeeping?.TaskCompletionRate ?? 0,
                                AverageCleaningMinutes = housekeeping?.AverageCleaningTimeMinutes ?? 0,
                                AverageGuestRating = housekeeping?.AverageServiceRequestRating ?? 0
                            },
                            SlaKpis = new
                            {
                                TotalRequests = sla?.TotalRequestCount ?? 0,
                                CompliantRequests = sla?.CompliantRequestCount ?? 0,
                                BreachedRequests = sla?.BreachedRequestCount ?? 0,
                                SlaComplianceRate = sla?.SlaComplianceRate ?? 0,
                                AverageResponseMinutes = sla?.AverageResponseMinutes ?? 0,
                                AverageResolutionMinutes = sla?.AverageResolutionMinutes ?? 0,
                                TopBreachingServices = sla?.TopBreachingServices?.Select(x => $"{x.ServiceName} ({x.BreachCount} ihlal)")?.ToList() ?? new List<string>()
                            }
                        };
                        prompt = BuildHotelManagerInsightPrompt(statsContext);
                    }
                    else // Department Scope
                    {
                        statsContext = new
                        {
                            DepartmentName = userDepartmentName,
                            DateRange = $"{startDate:yyyy-MM-dd} - {endDate:yyyy-MM-dd}",
                            TotalRequests = deptTotalRequests,
                            CompliantRequests = deptCompliantRequests,
                            BreachedRequests = deptBreachedRequests,
                            SlaComplianceRate = deptSlaComplianceRate,
                            AverageResponseMinutes = deptAvgResponse,
                            AverageResolutionMinutes = deptAvgResolution,
                            AverageRating = deptAvgRating,
                            TotalTasks = deptTotalTasks,
                            CompletedTasks = deptCompletedTasks,
                            OpenTasks = deptOpenTasks,
                            OverdueTasks = deptOverdueTasks,
                            PendingStockRequests = deptPendingStockRequests
                        };
                        prompt = BuildDepartmentManagerInsightPrompt(statsContext);
                    }

                    var client = _httpClientFactory.CreateClient();
                    var url = $"https://generativelanguage.googleapis.com/v1beta/models/{modelName}:generateContent?key={apiKey}";

                    var payload = new
                    {
                        contents = new[]
                        {
                            new
                            {
                                parts = new[]
                                {
                                    new { text = prompt }
                                }
                            }
                        }
                    };

                    var jsonContent = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                    
                    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(8));
                    var response = await client.PostAsync(url, jsonContent, cts.Token);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var responseJson = await response.Content.ReadAsStringAsync(cancellationToken);
                        using var doc = JsonDocument.Parse(responseJson);
                        var rawText = doc.RootElement
                            .GetProperty("candidates")[0]
                            .GetProperty("content")
                            .GetProperty("parts")[0]
                            .GetProperty("text")
                            .GetString();

                        if (!string.IsNullOrWhiteSpace(rawText))
                        {
                            var cleanText = rawText.Trim();
                            if (cleanText.StartsWith("```"))
                            {
                                var firstLineBreak = cleanText.IndexOf('\n');
                                var lastBackticks = cleanText.LastIndexOf("```");
                                if (firstLineBreak != -1 && lastBackticks != -1 && lastBackticks > firstLineBreak)
                                {
                                    cleanText = cleanText.Substring(firstLineBreak + 1, lastBackticks - firstLineBreak - 1).Trim();
                                }
                            }

                            var aiDoc = JsonDocument.Parse(cleanText);
                            responseData = new GetAiInsightsReportQueryResponse
                            {
                                ExecutiveSummary = aiDoc.RootElement.GetProperty("executiveSummary").GetString() ?? string.Empty,
                                Bottlenecks = aiDoc.RootElement.GetProperty("bottlenecks").GetString() ?? string.Empty,
                                Recommendations = aiDoc.RootElement.GetProperty("recommendations").GetString() ?? string.Empty,
                                RevenueOpportunities = aiDoc.RootElement.GetProperty("revenueOpportunities").GetString() ?? string.Empty,
                                GeneratedAt = DateTime.UtcNow,
                                IsAiGenerated = true,
                                InsightScope = insightScope,
                                RoleBasedMessage = roleBasedMessage,
                                DepartmentId = userDepartmentId,
                                DepartmentName = userDepartmentName
                            };
                            apiCallSuccessful = true;
                        }
                    }
                }
                catch (Exception)
                {
                    apiCallSuccessful = false;
                }
            }

            if (!apiCallSuccessful || responseData == null)
            {
                responseData = BuildFallbackInsightsByRole(
                    insightScope, roleBasedMessage, userDepartmentId, userDepartmentName, 
                    occupancy, foodSales, housekeeping, financial, sla, startDate, endDate,
                    deptTotalRequests, deptCompliantRequests, deptBreachedRequests, deptSlaComplianceRate,
                    deptAvgResponse, deptAvgResolution, deptAvgRating, deptTotalTasks, deptCompletedTasks,
                    deptOpenTasks, deptOverdueTasks, deptPendingStockRequests
                );
            }

            return new ResponseDto<GetAiInsightsReportQueryResponse>().Success(responseData);
        }

        private string BuildOwnerInsightPrompt(object statsContext)
        {
            var promptBuilder = new StringBuilder();
            promptBuilder.AppendLine("Sen profesyonel bir otel operasyon ve yatırım danışmanısın. Aşağıda paylaşılan aggregate otel performans verilerini analiz et.");
            promptBuilder.AppendLine("Veriler kişisel bilgi veya misafir ismi içermez. Tamamen toplu istatistiklerdir.");
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("### OTEL VERİLERİ (SAHİBİ/YÖNETİM KAPSAMI) ###");
            promptBuilder.AppendLine(JsonSerializer.Serialize(statsContext, new JsonSerializerOptions { WriteIndented = true }));
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("Görevin: Otel sahibi/ortakları için stratejik bir yönetici özeti, finansal risk analizleri ve yeni gelir fırsatları üretmektir.");
            promptBuilder.AppendLine("Lütfen yanıtını SADECE Türkçe dilinde ve aşağıdaki alanları içeren geçerli bir JSON nesnesi formatında dön.");
            promptBuilder.AppendLine("JSON formatı kesinlikle şu anahtarlara sahip olmalıdır:");
            promptBuilder.AppendLine("{");
            promptBuilder.AppendLine("  \"executiveSummary\": \"Otelin genel finansal ve operasyonel gidişatını özetleyen 2-3 cümlelik stratejik yönetici özeti.\",");
            promptBuilder.AppendLine("  \"bottlenecks\": \"Yüksek envanter maliyetleri, düşük kâr marjları veya operasyonel verimsizliklerin finansal yansımaları.\",");
            promptBuilder.AppendLine("  \"recommendations\": \"Kârlılığı ve kaynak verimliliğini artırmaya yönelik uzun vadeli stratejik öneriler.\",");
            promptBuilder.AppendLine("  \"revenueOpportunities\": \"Doluluk trendleri, ADR yükseltme potansiyelleri veya F&B ciro artırıcı yeni gelir modelleri.\"");
            promptBuilder.AppendLine("}");
            promptBuilder.AppendLine("JSON dışında hiçbir markdown bloğu, açıklama veya kod bloğu (```json gibi) ekleme. Sadece ve doğrudan geçerli JSON metnini dön.");
            return promptBuilder.ToString();
        }

        private string BuildHotelManagerInsightPrompt(object statsContext)
        {
            var promptBuilder = new StringBuilder();
            promptBuilder.AppendLine("Sen tecrübeli bir otel genel müdürüsün. Aşağıda paylaşılan aggregate otel operasyonel verilerini analiz et.");
            promptBuilder.AppendLine("Veriler kişisel bilgi veya misafir ismi içermez. Tamamen toplu istatistiklerdir.");
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("### OTEL OPERASYONEL VERİLERİ (GENEL MÜDÜR KAPSAMI) ###");
            promptBuilder.AppendLine(JsonSerializer.Serialize(statsContext, new JsonSerializerOptions { WriteIndented = true }));
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("Görevin: Günlük otel operasyonları, hizmet kalitesi, temizlik süreleri ve SLA uyumlulukları doğrultusunda aksiyon önerileri üretmektir.");
            promptBuilder.AppendLine("Lütfen yanıtını SADECE Türkçe dilinde ve aşağıdaki alanları içeren geçerli bir JSON nesnesi formatında dön.");
            promptBuilder.AppendLine("JSON formatı kesinlikle şu anahtarlara sahip olmalıdır:");
            promptBuilder.AppendLine("{");
            promptBuilder.AppendLine("  \"executiveSummary\": \"Otelin günlük operasyonel akışını, oda durumlarını ve misafir memnuniyetini özetleyen 2-3 cümlelik genel müdür özeti.\",");
            promptBuilder.AppendLine("  \"bottlenecks\": \"Housekeeping temizlik süreleri, geciken iç görevler veya SLA aşımı oluşturan darboğaz noktaları.\",");
            promptBuilder.AppendLine("  \"recommendations\": \"Hizmet kalitesini ve hızını artırmak için doğrudan operasyonel ve personel planlama önerileri.\",");
            promptBuilder.AppendLine("  \"revenueOpportunities\": \"Operasyonel uygunluğa göre ek hizmet satışı (geç çıkış, oda servis yoğunlukları) veya F&B sunum önerileri.\"");
            promptBuilder.AppendLine("}");
            promptBuilder.AppendLine("JSON dışında hiçbir markdown bloğu, açıklama veya kod bloğu (```json gibi) ekleme. Sadece ve doğrudan geçerli JSON metnini dön.");
            return promptBuilder.ToString();
        }

        private string BuildDepartmentManagerInsightPrompt(object statsContext)
        {
            var promptBuilder = new StringBuilder();
            promptBuilder.AppendLine("Sen bir otel departman müdürüsün. Aşağıda paylaşılan sadece senin departmanına ait verileri analiz et.");
            promptBuilder.AppendLine("Veriler kişisel bilgi veya misafir ismi içermez. Tamamen toplu departman istatistikleridir.");
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("### DEPARTMAN VERİLERİ (DEPARTMAN MÜDÜRÜ KAPSAMI) ###");
            promptBuilder.AppendLine(JsonSerializer.Serialize(statsContext, new JsonSerializerOptions { WriteIndented = true }));
            promptBuilder.AppendLine();
            promptBuilder.AppendLine("Görevin: Kendi departmanının hizmet kalitesini, SLA uyumunu, personel iş yükünü ve bekleyen işleri optimize edecek aksiyonlar önermektir.");
            promptBuilder.AppendLine("Lütfen yanıtını SADECE Türkçe dilinde ve aşağıdaki alanları içeren geçerli bir JSON nesnesi formatında dön.");
            promptBuilder.AppendLine("JSON formatı kesinlikle şu anahtarlara sahip olmalıdır:");
            promptBuilder.AppendLine("{");
            promptBuilder.AppendLine("  \"executiveSummary\": \"Departmanın genel performans durumunu, bekleyen görev yükünü ve SLA başarısını özetleyen 2-3 cümlelik departman özeti.\",");
            promptBuilder.AppendLine("  \"bottlenecks\": \"Departman içindeki işlerin gecikme nedenleri, aşırı iş yükü olan veya geciken personel durumları.\",");
            promptBuilder.AppendLine("  \"recommendations\": \"Departman verimliliğini artırmaya ve gecikmeleri azaltmaya yönelik pratik departman içi aksiyon planları.\",");
            promptBuilder.AppendLine("  \"revenueOpportunities\": \"Departmanın sunduğu hizmet veya kaynakların (örneğin ek hizmetler, departman bazlı ürün talepleri) verimlilik ve ciro potansiyelleri.\"");
            promptBuilder.AppendLine("}");
            promptBuilder.AppendLine("JSON dışında hiçbir markdown bloğu, açıklama veya kod bloğu (```json gibi) ekleme. Sadece ve doğrudan geçerli JSON metnini dön.");
            return promptBuilder.ToString();
        }

        private GetAiInsightsReportQueryResponse BuildFallbackInsightsByRole(
            string scope,
            string roleBasedMessage,
            int? deptId,
            string? deptName,
            GetOccupancyReportQueryResponse occupancy,
            GetFoodSalesReportQueryResponse foodSales,
            GetHousekeepingReportQueryResponse housekeeping,
            GetFinancialSummaryReportQueryResponse financial,
            GetSlaComplianceReportQueryResponse sla,
            DateTime startDate,
            DateTime endDate,
            int deptTotalRequests,
            int deptCompliantRequests,
            int deptBreachedRequests,
            decimal deptSlaComplianceRate,
            decimal deptAvgResponse,
            decimal deptAvgResolution,
            decimal deptAvgRating,
            int deptTotalTasks,
            int deptCompletedTasks,
            int deptOpenTasks,
            int deptOverdueTasks,
            int deptPendingStockRequests)
        {
            var summary = new StringBuilder();
            var bottlenecks = new StringBuilder();
            var recommendations = new StringBuilder();
            var revenues = new StringBuilder();

            if (scope == "FullHotel")
            {
                var occRate = occupancy?.OccupancyRate ?? 0m;
                var grossProfit = financial?.GrossProfit ?? 0m;
                var slaRate = sla?.SlaComplianceRate ?? 100m;
                var avgResolution = sla?.AverageResolutionMinutes ?? 0m;

                summary.Append($"Finansal ve stratejik analiz döneminde ({startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}), otel brüt kârı {grossProfit:N0} TRY olarak gerçekleşmiştir. Doluluk oranı %{occRate:F0} düzeyindedir.");
                
                if (slaRate < 75m)
                {
                    bottlenecks.Append($"SLA uyumluluğundaki düşüş (%{slaRate:F1}) ve ortalama çözüm süresinin {avgResolution:F0} dakika olması operasyonel maliyetleri ve misafir memnuniyetsizlik riskini artırmaktadır.");
                    recommendations.Append("Maliyet optimizasyonu için envanter satın alma süreçleri denetlenmeli ve SLA aşımlarını azaltarak iş gücü kaybının önüne geçilmelidir.");
                }
                else
                {
                    bottlenecks.Append("Önemli bir finansal risk veya darboğaz tespit edilmemiştir. Operasyonel maliyetler bütçe hedefleriyle uyumludur.");
                    recommendations.Append("Hacimsel karlılığı korumak adına departmanlar arası bütçe sınırları ve tedarikçi anlaşmaları yıllık bazda sabitlenmeye çalışılmalıdır.");
                }

                if (occRate >= 80m)
                {
                    revenues.Append($"Yüksek doluluk (%{occRate:F0}) avantajı kullanılarak dinamik oda fiyatlandırma (ADR) stratejisi uygulanmalı ve oda kârlılığı maksimize edilmelidir.");
                }
                else
                {
                    revenues.Append("Düşük doluluk dönemlerinde oda kârlılığını artırmak için sadakat programları ve oda yükseltme paketleri tasarlanmalıdır.");
                }
            }
            else if (scope == "Operations")
            {
                var occRate = occupancy?.OccupancyRate ?? 0m;
                var avgCleaning = housekeeping?.AverageCleaningTimeMinutes ?? 0m;
                var housekeepingRating = housekeeping?.AverageServiceRequestRating ?? 0m;
                var slaRate = sla?.SlaComplianceRate ?? 100m;
                var avgResponse = sla?.AverageResponseMinutes ?? 0m;
                var avgResolution = sla?.AverageResolutionMinutes ?? 0m;

                summary.Append($"Operasyonel analiz döneminde ({startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}), genel SLA uyum oranı %{slaRate:F1} düzeyinde gerçekleşmiştir. Otel doluluk oranı ise %{occRate:F0}'dir.");

                if (slaRate < 75m || avgCleaning > 45m)
                {
                    bottlenecks.Append($"Hizmet taleplerindeki ortalama yanıt süresi {avgResponse:F1} dakika, çözüm süresi ise {avgResolution:F1} dakikadır. ");
                    if (avgCleaning > 45m)
                    {
                        bottlenecks.Append($"Housekeeping oda temizleme süresi ({avgCleaning:F0} dk) standart limitlerin üzerindedir.");
                    }
                    recommendations.Append("Yoğun saatlerde check-in ve housekeeping personel vardiyaları optimize edilmelidir. Kat görevlilerinin temizlik süreçleri hızlandırılmalı ve denetlenmelidir.");
                }
                else
                {
                    bottlenecks.Append("Kritik bir operasyonel darboğaz tespit edilmemiş olup, departmanların iş süreleri dengeli seyretmektedir.");
                    recommendations.Append("Mevcut standartların korunması için personel performans takipleri haftalık olarak sürdürülmelidir.");
                }

                revenues.Append("Misafir memnuniyetini artırıcı operasyonel hız (SLA) öne çıkarılarak, erken giriş (Early check-in) veya VIP servis paketlerinin aktif tanıtımı yapılabilir.");
            }
            else if (scope == "Department")
            {
                summary.Append($"{deptName} departmanı analiz döneminde ({startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}), toplam {deptTotalRequests} hizmet talebi ve {deptTotalTasks} iç görev yönetmiştir. SLA uyum oranı %{deptSlaComplianceRate:F1}'dir.");

                if (deptSlaComplianceRate < 75m || deptOverdueTasks > 0)
                {
                    bottlenecks.Append($"Ortalama yanıt süresi {deptAvgResponse:F1} dakika ve çözüm süresi {deptAvgResolution:F1} dakikadır. ");
                    if (deptOverdueTasks > 0)
                    {
                        bottlenecks.Append($"Departmanda teslim tarihi gecikmiş {deptOverdueTasks} aktif iç görev bulunmaktadır.");
                    }
                    if (deptPendingStockRequests > 0)
                    {
                        bottlenecks.Append($" Satın alma onayında bekleyen {deptPendingStockRequests} adet stok talebi bulunmaktadır.");
                    }
                    recommendations.Append("Geciken iç görevlerin kapatılması için personel görev dağılımı güncellenmeli ve departman içi günlük koordinasyon toplantısı yapılmalıdır.");
                }
                else
                {
                    bottlenecks.Append("Darboğaz bulunmamaktadır. Görevler ve hizmet talepleri hedeflenen süreler içinde tamamlanmaktadır.");
                    recommendations.Append("SLA uyum başarısından ötürü departman çalışanlarına yönelik motivasyonel geri bildirimler verilmesi tavsiye edilir.");
                }

                if (deptAvgRating > 0 && deptAvgRating < 4.0m)
                {
                    recommendations.Append($" Misafir memnuniyet ortalaması (5 üzerinden {deptAvgRating:F1}) kritik seviyededir. Hizmet kalitesi standartları kontrol edilmelidir.");
                }

                revenues.Append("Departman kaynaklarının kullanım verimliliği optimize edilerek, operasyonel sarf malzemelerinin israfı önlenmeli ve stok verimliliği artırılmalıdır.");
            }

            return new GetAiInsightsReportQueryResponse
            {
                ExecutiveSummary = summary.ToString().Trim(),
                Bottlenecks = bottlenecks.ToString().Trim(),
                Recommendations = recommendations.ToString().Trim(),
                RevenueOpportunities = revenues.ToString().Trim(),
                GeneratedAt = DateTime.UtcNow,
                IsAiGenerated = false,
                InsightScope = scope,
                RoleBasedMessage = roleBasedMessage,
                DepartmentId = deptId,
                DepartmentName = deptName
            };
        }
    }
}

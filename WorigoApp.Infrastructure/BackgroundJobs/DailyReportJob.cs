using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using WorigoApp.Application.Interfaces.BackgroundJobs;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport;
using WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport;
using WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport;

namespace WorigoApp.Infrastructure.BackgroundJobs
{
    /// <summary>
    /// DailyReportJob sınıfını temsil eder.
    /// </summary>
    public class DailyReportJob : IDailyReportJob
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DailyReportJob> _logger;
/// <summary>
/// DailyReportJob sınıfının yeni bir örneğini başlatır.
/// </summary>
public DailyReportJob(IMediator mediator, IUnitOfWork unitOfWork, ILogger<DailyReportJob> logger)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
/// <summary>
/// SendDailyReportsAsync işlemini gerçekleştirir.
/// </summary>
public async Task SendDailyReportsAsync()
        {
            _logger.LogInformation("Daily morning report background job started at {Time}", DateTime.UtcNow);

            try
            {
                var hotels = await _unitOfWork.GetReadRepository<Hotel>().GetAllAsync(x => !x.IsDeleted);
                _logger.LogInformation("Found {Count} active hotel(s) to process reports.", hotels.Count);

                foreach (var hotel in hotels)
                {
                    _logger.LogInformation("Compiling report data for Hotel: {HotelName} (ID: {HotelId})", hotel.Name, hotel.Id);

                    var today = DateTime.Today;
                    var yesterday = today.AddDays(-1);

                    var occupancyResponse = await _mediator.Send(new GetOccupancyReportQueryRequest
                    {
                        HotelId = hotel.Id,
                        Date = today
                    });

                    var foodSalesResponse = await _mediator.Send(new GetFoodSalesReportQueryRequest
                    {
                        HotelId = hotel.Id,
                        StartDate = yesterday,
                        EndDate = today
                    });

                    var financialResponse = await _mediator.Send(new GetFinancialSummaryReportQueryRequest
                    {
                        HotelId = hotel.Id,
                        StartDate = yesterday,
                        EndDate = today
                    });

                    if (occupancyResponse.IsSuccess && occupancyResponse.Data != null)
                    {
                        var occ = occupancyResponse.Data;
                        _logger.LogInformation("Occupancy Report compiled: {OccupancyRate}% Occupied ({Occupied}/{Total} Rooms), {Clean} Clean, {Dirty} Dirty, {ExpectedArrivals} Arrivals, {ExpectedDepartures} Departures.",
                            occ.OccupancyRate, occ.OccupiedRoomCount, occ.TotalRoomCount, occ.CleanRoomCount, occ.DirtyRoomCount, occ.ExpectedArrivalsCount, occ.ExpectedDeparturesCount);
                    }

                    if (foodSalesResponse.IsSuccess && foodSalesResponse.Data != null)
                    {
                        var food = foodSalesResponse.Data;
                        _logger.LogInformation("F&B Sales Report compiled: {TotalOrders} Orders, Total Revenue: {Revenue} TRY, Average Order Value: {Avg} TRY.",
                            food.TotalOrdersCount, food.TotalRevenue, food.AverageOrderValue);
                    }

                    if (financialResponse.IsSuccess && financialResponse.Data != null)
                    {
                        var fin = financialResponse.Data;
                        _logger.LogInformation("Financial Summary compiled: Revenue: {Revenue} TRY, Costs: {Cost} TRY, Profit: {Profit} TRY.",
                            fin.TotalRevenue, fin.TotalPurchaseCost, fin.GrossProfit);
                    }

                    // Email Sending logic is intentionally disabled (job kapat/taslak durumunda)
                    _logger.LogInformation("Email sending for daily morning report is currently disabled. Report successfully logged.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while running the daily morning report background job.");
            }

            _logger.LogInformation("Daily morning report background job completed successfully.");
        }
    }
}

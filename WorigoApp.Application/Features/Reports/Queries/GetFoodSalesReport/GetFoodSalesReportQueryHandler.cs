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

namespace WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport
{
/// <summary>
/// GetFoodSalesReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetFoodSalesReportQueryHandler : BaseHandler, IRequestHandler<GetFoodSalesReportQueryRequest, ResponseDto<GetFoodSalesReportQueryResponse>>
    {
/// <summary>
/// GetFoodSalesReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetFoodSalesReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetFoodSalesReportQueryResponse>> Handle(GetFoodSalesReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetFoodSalesReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var startDate = request.StartDate ?? DateTime.MinValue;
            var endDate = request.EndDate ?? DateTime.MaxValue;

            var orders = await unitOfWork.GetReadRepository<Order>().GetAllAsync(
                x => x.GuestStay.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     x.CreatedDate >= startDate &&
                     x.CreatedDate <= endDate,
                include: q => q.Include(x => x.OrderItems));

            var totalOrdersCount = orders.Count;
            var totalRevenue = orders.Sum(x => x.TotalPrice);
            var averageOrderValue = totalOrdersCount == 0 ? 0 : Math.Round(totalRevenue / totalOrdersCount, 2);

            var topSellingItems = orders.SelectMany(x => x.OrderItems)
                .GroupBy(x => new { x.ServiceItemId, x.Text })
                .Select(g => new TopSellingItemDto
                {
                    ItemName = string.IsNullOrWhiteSpace(g.Key.Text) ? $"Ürün #{g.Key.ServiceItemId}" : g.Key.Text,
                    Quantity = g.Sum(x => x.Quantity),
                    Revenue = g.Sum(x => x.LineTotal)
                })
                .OrderByDescending(x => x.Quantity)
                .Take(10)
                .ToList();

            var hourlyDistribution = orders
                .GroupBy(x => x.CreatedDate.Hour)
                .Select(g => new HourlyOrderDto
                {
                    Hour = g.Key,
                    OrderCount = g.Count()
                })
                .OrderBy(x => x.Hour)
                .ToList();

            var fullDistribution = new List<HourlyOrderDto>();
            for (int i = 0; i < 24; i++)
            {
                var existing = hourlyDistribution.FirstOrDefault(x => x.Hour == i);
                fullDistribution.Add(existing ?? new HourlyOrderDto { Hour = i, OrderCount = 0 });
            }

            var response = new GetFoodSalesReportQueryResponse
            {
                TotalOrdersCount = totalOrdersCount,
                TotalRevenue = totalRevenue,
                AverageOrderValue = averageOrderValue,
                TopSellingItems = topSellingItems,
                HourlyOrderDistribution = fullDistribution
            };

            return new ResponseDto<GetFoodSalesReportQueryResponse>().Success(response);
        }
    }
}

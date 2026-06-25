using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport
{
/// <summary>
/// GetOccupancyReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetOccupancyReportQueryHandler : BaseHandler, IRequestHandler<GetOccupancyReportQueryRequest, ResponseDto<GetOccupancyReportQueryResponse>>
    {
/// <summary>
/// GetOccupancyReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetOccupancyReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetOccupancyReportQueryResponse>> Handle(GetOccupancyReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<GetOccupancyReportQueryResponse>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

            var targetDate = request.Date?.Date ?? DateTime.Today;

            var rooms = await unitOfWork.GetReadRepository<Room>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted);

            var stays = await unitOfWork.GetReadRepository<GuestStay>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted && x.Status == "Active");

            var totalRoomCount = rooms.Count;
            var occupiedRoomCount = rooms.Count(x => x.IsFull || x.CurrentStatus.Equals("Occupied", StringComparison.OrdinalIgnoreCase));
            var occupancyRate = totalRoomCount == 0 ? 0 : Math.Round((decimal)occupiedRoomCount / totalRoomCount * 100m, 2);

            var cleanRoomCount = rooms.Count(x => x.CurrentStatus.Equals("Available", StringComparison.OrdinalIgnoreCase) || x.CurrentStatus.Equals("Clean", StringComparison.OrdinalIgnoreCase));
            var dirtyRoomCount = rooms.Count(x => x.CurrentStatus.Equals("Dirty", StringComparison.OrdinalIgnoreCase) || x.CurrentStatus.Equals("Cleaning", StringComparison.OrdinalIgnoreCase));
            var outOfOrderRoomCount = rooms.Count(x => x.CurrentStatus.Equals("OutOfOrder", StringComparison.OrdinalIgnoreCase) || x.CurrentStatus.Equals("Maintenance", StringComparison.OrdinalIgnoreCase));

            var expectedArrivals = stays.Count(x => x.CheckInDate.Date == targetDate && x.ActualCheckInAt == null);
            var expectedDepartures = stays.Count(x => x.CheckOutDate.Date == targetDate && x.ActualCheckOutAt == null);
            var vipCount = stays.Count(x => x.IsVip);

            var response = new GetOccupancyReportQueryResponse
            {
                TotalRoomCount = totalRoomCount,
                OccupiedRoomCount = occupiedRoomCount,
                OccupancyRate = occupancyRate,
                CleanRoomCount = cleanRoomCount,
                DirtyRoomCount = dirtyRoomCount,
                OutOfOrderRoomCount = outOfOrderRoomCount,
                ExpectedArrivalsCount = expectedArrivals,
                ExpectedDeparturesCount = expectedDepartures,
                VIPGuestsCount = vipCount
            };

            return new ResponseDto<GetOccupancyReportQueryResponse>().Success(response);
        }
    }
}

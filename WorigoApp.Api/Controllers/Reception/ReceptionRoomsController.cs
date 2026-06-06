using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception
{
    [ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception/rooms")]
    public class ReceptionRoomsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ReceptionRoomsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ResponseDto<IList<ReceptionRoomResponse>>> Get([FromQuery] int hotelId, CancellationToken cancellationToken)
        {
            if (hotelId <= 0)
            {
                return new ResponseDto<IList<ReceptionRoomResponse>>().Fail("HotelId zorunludur.", 400);
            }

            var roomsList = await _dbContext.Set<Room>()
                .AsNoTracking()
                .Include(x => x.RoomType)
                .Where(x => x.HotelId == hotelId && !x.IsDeleted)
                .OrderBy(x => x.FloorNo ?? 0)
                .ThenBy(x => x.RoomNumber ?? x.Name)
                .ToListAsync(cancellationToken);

            var activeStays = await _dbContext.Set<GuestStay>()
                .AsNoTracking()
                .Include(x => x.Orders)
                .Include(x => x.Charges)
                .Where(x => x.HotelId == hotelId && x.IsActive && !x.IsDeleted && x.ActualCheckOutAt == null)
                .ToListAsync(cancellationToken);

            var payments = await _dbContext.Set<PaymentTransaction>()
                .AsNoTracking()
                .Where(x => x.Charge.GuestStay.HotelId == hotelId && x.PaymentStatus == OrderPaymentStatusEnum.Paid && !x.IsDeleted)
                .ToListAsync(cancellationToken);

            var rooms = roomsList.Select(r => {
                var stay = activeStays.FirstOrDefault(x => x.RoomId == r.Id);
                var isVip = false;
                var hasAllergy = false;
                var dnd = false;
                var lateCheckout = false;
                var hasUnpaidFolio = false;

                if (stay is not null)
                {
                    isVip = stay.IsVip || stay.AccommodationConceptType == AccommodationConceptTypeEnum.UltraAllInclusive;
                    hasAllergy = stay.HasAllergy;
                    dnd = stay.DoNotDisturb;
                    lateCheckout = stay.IsLateCheckOut;

                    // Calculate remaining balance
                    var stayDays = Math.Max(1, (stay.CheckOutDate.Date - stay.CheckInDate.Date).Days);
                    var totalCharges = stay.TotalPrice 
                        + stay.Charges.Where(c => c.Amount > 0 && c.OrderId == null && !c.IsDeleted).Sum(c => c.Amount)
                        + stay.Orders.Where(o => o.PaymentOption == OrderPaymentOptionEnum.RoomCharge && !o.IsDeleted).Sum(o => o.TotalPrice);
                    
                    var totalPayments = stay.Charges.Where(c => c.Amount < 0 && !c.IsDeleted).Sum(c => -c.Amount);
                    var paymentsSum = payments.Where(pt => pt.Charge.GuestStayId == stay.Id).Sum(pt => pt.Amount);
                    totalPayments += paymentsSum;

                    hasUnpaidFolio = (totalCharges - totalPayments) > 0.05m;
                }

                return new ReceptionRoomResponse
                {
                    Id = r.Id,
                    Name = r.Name,
                    RoomNumber = r.RoomNumber,
                    DisplayName = !string.IsNullOrWhiteSpace(r.RoomNumber) ? r.RoomNumber! : r.Name,
                    RoomTypeId = r.RoomTypeId,
                    RoomType = r.RoomType != null ? r.RoomType.Name : string.Empty,
                    RoomTypeValue = r.RoomType != null ? r.RoomTypeId : 0,
                    FloorNo = r.FloorNo,
                    Capacity = r.Capacity,
                    Description = r.Description,
                    IsFull = r.IsFull,
                    CurrentStatus = r.CurrentStatus,
                    Price = r.Price,
                    InternalPhoneNumber = r.InternalPhoneNumber,
                    
                    // Badges
                    IsVip = isVip,
                    HasAllergy = hasAllergy,
                    DoNotDisturb = dnd,
                    IsLateCheckOut = lateCheckout,
                    HasUnpaidFolio = hasUnpaidFolio,
                    CheckInDate = stay?.CheckInDate,
                    CheckOutDate = stay?.CheckOutDate
                };
            }).ToList();
 
            return new ResponseDto<IList<ReceptionRoomResponse>>().Success(rooms);
        }
    }
 
    public class ReceptionRoomResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? RoomNumber { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public string RoomType { get; set; } = string.Empty;
        public int RoomTypeValue { get; set; }
        public int? FloorNo { get; set; }
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public bool IsFull { get; set; }
        public string CurrentStatus { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? InternalPhoneNumber { get; set; }
 
        public bool IsVip { get; set; }
        public bool HasAllergy { get; set; }
        public bool DoNotDisturb { get; set; }
        public bool IsLateCheckOut { get; set; }
        public bool HasUnpaidFolio { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }
}

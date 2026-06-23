using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class RestaurantReservation : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int GuestStayId { get; set; }
        public GuestStay GuestStay { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
        public DateTime ReservationDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public int GuestCount { get; set; }
        public string? Note { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected, Cancelled
        public int? ApprovedByEmployeeId { get; set; }
        public Employee? ApprovedByEmployee { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
    }
}

using System;
using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class SpaAppointment : EntityBase
    {
        public int HotelId { get; set; }
        public int GuestStayId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public string TherapistName { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public string Status { get; set; } = "Confirmed";
        
        public GuestStay GuestStay { get; set; } = null!;
    }
}

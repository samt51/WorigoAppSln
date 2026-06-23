namespace WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus
{
    public class RoomAvailabilityStatusResponse
    {
        public int GuestStayId { get; set; }
        public string Status { get; set; } = "Normal";
        public DateTime UpdatedAt { get; set; }
    }
}

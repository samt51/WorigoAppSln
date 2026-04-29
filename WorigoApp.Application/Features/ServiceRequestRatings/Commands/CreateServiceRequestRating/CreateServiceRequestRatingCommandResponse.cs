namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating
{
    public class CreateServiceRequestRatingCommandResponse
    {
        public int Id { get; set; }
        public int ServiceRequestId { get; set; }
        public decimal SpeedScore { get; set; }
        public decimal QualityScore { get; set; }
        public decimal StaffScore { get; set; }
        public DateTime RatedAt { get; set; }
    }
}

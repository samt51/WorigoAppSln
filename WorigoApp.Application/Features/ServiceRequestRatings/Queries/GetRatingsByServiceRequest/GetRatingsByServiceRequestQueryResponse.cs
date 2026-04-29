namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest
{
    public class GetRatingsByServiceRequestQueryResponse
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public decimal SpeedScore { get; set; }
        public decimal QualityScore { get; set; }
        public decimal StaffScore { get; set; }
        public string? Comment { get; set; }
        public DateTime RatedAt { get; set; }
    }
}

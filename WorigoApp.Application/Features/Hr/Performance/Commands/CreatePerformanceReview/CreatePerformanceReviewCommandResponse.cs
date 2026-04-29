namespace WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview
{
    public class CreatePerformanceReviewCommandResponse
    {
        public int Id { get; set; }
        public decimal Score { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}

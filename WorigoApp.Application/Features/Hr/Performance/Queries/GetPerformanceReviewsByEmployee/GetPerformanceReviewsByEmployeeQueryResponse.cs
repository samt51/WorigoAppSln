using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee
{
    public class GetPerformanceReviewsByEmployeeQueryResponse
    {
        public int Id { get; set; }
        public decimal Score { get; set; }
        public string? Strengths { get; set; }
        public string? ImprovementAreas { get; set; }
        public string? ManagerNote { get; set; }
        public PerformanceReviewStatusEnum Status { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}

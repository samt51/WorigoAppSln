using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview
{
    public class CreatePerformanceReviewCommandRequest : IRequest<ResponseDto<CreatePerformanceReviewCommandResponse>>
    {
        public int HotelId { get; set; }
        public int EmployeeId { get; set; }
        public int ReviewerEmployeeId { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public decimal Score { get; set; }
        public string? Strengths { get; set; }
        public string? ImprovementAreas { get; set; }
        public string? ManagerNote { get; set; }
        public PerformanceReviewStatusEnum Status { get; set; } = PerformanceReviewStatusEnum.Submitted;
    }
}

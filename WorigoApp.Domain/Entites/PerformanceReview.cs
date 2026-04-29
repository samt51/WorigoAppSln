using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin yonetici tarafindan yapilan performans degerlendirme kaydini tutar.
    /// </summary>
    public class PerformanceReview : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int ReviewerEmployeeId { get; set; }
        public Employee ReviewerEmployee { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public decimal Score { get; set; }
        public string? Strengths { get; set; }
        public string? ImprovementAreas { get; set; }
        public string? ManagerNote { get; set; }
        public PerformanceReviewStatusEnum Status { get; set; } = PerformanceReviewStatusEnum.Submitted;
    }
}

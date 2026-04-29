using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport
{
    public class GetTopIssueReportQueryResponse
    {
        public ServicesEnum ServiceType { get; set; }
        public int? ServiceCatalogItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int TotalCount { get; set; }
        public int OpenCount { get; set; }
        public decimal AverageResolutionMinutes { get; set; }
    }
}

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport;
using WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport;
using WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport;
using WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport;
using WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport;
using WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport;
using WorigoApp.Application.Features.Reports.Queries.GetHousekeepingReport;
using WorigoApp.Application.Features.Reports.Queries.GetSlaComplianceReport;
using WorigoApp.Application.Features.Reports.Queries.GetAiInsightsReport;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Reports
{
    /// <summary>
    /// ReportsController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin,HotelAdmin,Management,HRManager,PurchasingManager")]
    public class ReportsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// ReportsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReportsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Taleplerin SLA uyum oranlarini ve yanit/cozum surelerini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Taleplerin SLA uyum oranlarini ve yanit/cozum surelerini verir.")]
        public async Task<ResponseDto<GetSlaComplianceReportQueryResponse>> SlaCompliance([FromQuery] GetSlaComplianceReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Otel verilerini analiz ederek yoneticiler icin yapay zeka ve kural tabanli aksiyon onerileri uretir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Otel verilerini analiz ederek yoneticiler icin yapay zeka ve kural tabanli aksiyon onerileri uretir.")]
        public async Task<ResponseDto<GetAiInsightsReportQueryResponse>> AiInsights([FromQuery] GetAiInsightsReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Otel doluluk oranlarini ve oda durum dagilimlarini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Otel doluluk oranlarini ve oda durum dagilimlarini verir.")]
        public async Task<ResponseDto<GetOccupancyReportQueryResponse>> Occupancy([FromQuery] GetOccupancyReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Yiyecek/Icecek satis cirolarini ve en cok satan menuleri listeler.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Yiyecek/Icecek satis cirolarini ve en cok satan menuleri listeler.")]
        public async Task<ResponseDto<GetFoodSalesReportQueryResponse>> FoodSales([FromQuery] GetFoodSalesReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Housekeeping temizlik ve oda hazirlama performans metriklerini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Housekeeping temizlik ve oda hazirlama performans metriklerini verir.")]
        public async Task<ResponseDto<GetHousekeepingReportQueryResponse>> Housekeeping([FromQuery] GetHousekeepingReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Gelir, alim maliyeti ve servis memnuniyeti ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Gelir, alim maliyeti ve servis memnuniyeti ozetini verir.")]
        public async Task<ResponseDto<GetFinancialSummaryReportQueryResponse>> FinancialSummary([FromQuery] GetFinancialSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Personel bazli performans raporunu verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Personel bazli performans raporunu verir.")]
        public async Task<ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>> EmployeePerformance([FromQuery] GetEmployeePerformanceReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Departman bazli operasyon ve stok performansini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Departman bazli operasyon ve stok performansini verir.")]
        public async Task<ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>> DepartmentPerformance([FromQuery] GetDepartmentPerformanceReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// En cok tekrar eden ariza ve servis taleplerini listeler.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("En cok tekrar eden ariza ve servis taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetTopIssueReportQueryResponse>>> TopIssues([FromQuery] GetTopIssueReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Stok sagligi ve bekleyen talep ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Stok sagligi ve bekleyen talep ozetini verir.")]
        public async Task<ResponseDto<GetStockSummaryReportQueryResponse>> StockSummary([FromQuery] GetStockSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Departman bazli izin talebi ve izin gunu ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Departman bazli izin talebi ve izin gunu ozetini verir.")]
        public async Task<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>> LeaveSummary([FromQuery] GetLeaveSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Devam, gec kalma ve fazla mesai ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Devam, gec kalma ve fazla mesai ozetini verir.")]
        public async Task<ResponseDto<GetAttendanceSummaryReportQueryResponse>> AttendanceSummary([FromQuery] GetAttendanceSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Ic gorevlerin durum ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Ic gorevlerin durum ozetini verir.")]
        public async Task<ResponseDto<GetTaskSummaryReportQueryResponse>> TaskSummary([FromQuery] GetTaskSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Performans degerlendirme skor ozetini verir.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Performans degerlendirme skor ozetini verir.")]
        public async Task<ResponseDto<GetPerformanceSummaryReportQueryResponse>> PerformanceSummary([FromQuery] GetPerformanceSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}

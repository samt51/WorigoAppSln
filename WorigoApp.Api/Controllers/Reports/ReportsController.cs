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
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Reports
{
    [Authorize]
    public class ReportsController : BaseController
    {
        private readonly IMediator _mediator;

        public ReportsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Gelir, alim maliyeti ve servis memnuniyeti ozetini verir.")]
        public async Task<ResponseDto<GetFinancialSummaryReportQueryResponse>> FinancialSummary([FromQuery] GetFinancialSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Personel bazli performans raporunu verir.")]
        public async Task<ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>> EmployeePerformance([FromQuery] GetEmployeePerformanceReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Departman bazli operasyon ve stok performansini verir.")]
        public async Task<ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>> DepartmentPerformance([FromQuery] GetDepartmentPerformanceReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("En cok tekrar eden ariza ve servis taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetTopIssueReportQueryResponse>>> TopIssues([FromQuery] GetTopIssueReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Stok sagligi ve bekleyen talep ozetini verir.")]
        public async Task<ResponseDto<GetStockSummaryReportQueryResponse>> StockSummary([FromQuery] GetStockSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Departman bazli izin talebi ve izin gunu ozetini verir.")]
        public async Task<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>> LeaveSummary([FromQuery] GetLeaveSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Devam, gec kalma ve fazla mesai ozetini verir.")]
        public async Task<ResponseDto<GetAttendanceSummaryReportQueryResponse>> AttendanceSummary([FromQuery] GetAttendanceSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Ic gorevlerin durum ozetini verir.")]
        public async Task<ResponseDto<GetTaskSummaryReportQueryResponse>> TaskSummary([FromQuery] GetTaskSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Performans degerlendirme skor ozetini verir.")]
        public async Task<ResponseDto<GetPerformanceSummaryReportQueryResponse>> PerformanceSummary([FromQuery] GetPerformanceSummaryReportQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}

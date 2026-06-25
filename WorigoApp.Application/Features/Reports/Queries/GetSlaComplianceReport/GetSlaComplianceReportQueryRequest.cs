using MediatR;
using System;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetSlaComplianceReport
{
    /// <summary>
    /// SLA ve operasyonel KPI raporu almak için kullanılan istek modeli.
    /// </summary>
    public class GetSlaComplianceReportQueryRequest : IRequest<ResponseDto<GetSlaComplianceReportQueryResponse>>
    {
        /// <summary>
        /// Raporu talep edilen otelin ID bilgisi.
        /// </summary>
        public int HotelId { get; set; }

        /// <summary>
        /// Raporlama tarih aralığının başlangıç zamanı.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Raporlama tarih aralığının bitiş zamanı.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// İstekleri belirli bir departmana göre filtrelemek için kullanılan departman ID bilgisi.
        /// </summary>
        public int? DepartmentId { get; set; }
    }
}

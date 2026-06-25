using MediatR;
using System;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetAiInsightsReport
{
    /// <summary>
    /// Rol bazlı AI Insights (Yapay Zeka Yönetici Raporu) almak için kullanılan istek modeli.
    /// </summary>
    public class GetAiInsightsReportQueryRequest : IRequest<ResponseDto<GetAiInsightsReportQueryResponse>>
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
    }
}

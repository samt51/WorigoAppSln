using System;

namespace WorigoApp.Application.Features.Reports.Queries.GetAiInsightsReport
{
    /// <summary>
    /// Rol bazlı AI Insights (Yapay Zeka Yönetici Analizi) raporunun yanıt modeli.
    /// </summary>
    public class GetAiInsightsReportQueryResponse
    {
        /// <summary>
        /// Otel veya departman durumunu genel hatlarıyla özetleyen yönetici özeti.
        /// </summary>
        public string ExecutiveSummary { get; set; } = string.Empty;

        /// <summary>
        /// SLA gecikmeleri, yüksek arızalar veya temizlik sürelerindeki yavaşlıklar gibi operasyonel darboğaz analizleri.
        /// </summary>
        public string Bottlenecks { get; set; } = string.Empty;

        /// <summary>
        /// Operasyonel hızı, personel planlamasını ve verimliliği artırmaya yönelik aksiyon önerileri.
        /// </summary>
        public string Recommendations { get; set; } = string.Empty;

        /// <summary>
        /// Doluluk oranları, dinamik fiyatlama ve F&B trendlerine göre ek ciro/gelir fırsatı önerileri.
        /// </summary>
        public string RevenueOpportunities { get; set; } = string.Empty;

        /// <summary>
        /// Analizin oluşturulduğu zaman bilgisi (UTC).
        /// </summary>
        public DateTime GeneratedAt { get; set; }

        /// <summary>
        /// Analizin yapay zeka (Gemini) ile üretilip üretilmediği bilgisi. (Fallback motoru çalıştıysa false döner).
        /// </summary>
        public bool IsAiGenerated { get; set; }

        /// <summary>
        /// Kullanıcının rolüne göre atanan veri görünürlük kapsamı ("FullHotel", "Operations", "Department").
        /// </summary>
        public string InsightScope { get; set; } = string.Empty;

        /// <summary>
        /// Rol bazlı atanan izin ve veri kısıtlama durumunu açıklayan bildirim mesajı.
        /// </summary>
        public string RoleBasedMessage { get; set; } = string.Empty;

        /// <summary>
        /// Sadece "Department" kapsamında analiz yapılıyorsa, departman müdürünün departman ID bilgisi.
        /// </summary>
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Sadece "Department" kapsamında analiz yapılıyorsa, departman müdürünün departman adı.
        /// </summary>
        public string? DepartmentName { get; set; }
    }
}

using System.Collections.Generic;

namespace WorigoApp.Application.Features.Reports.Queries.GetSlaComplianceReport
{
    /// <summary>
    /// SLA ve operasyonel KPI raporu yanıt modeli.
    /// </summary>
    public class GetSlaComplianceReportQueryResponse
    {
        /// <summary>
        /// İlgili dönemde oluşturulan toplam talep adedi.
        /// </summary>
        public int TotalRequestCount { get; set; }

        /// <summary>
        /// SLA standartlarına uygun sürelerde çözülen toplam talep adedi.
        /// </summary>
        public int CompliantRequestCount { get; set; }

        /// <summary>
        /// SLA standartlarını aşarak çözülen (veya hala çözülmemiş olan geciken) toplam talep adedi.
        /// </summary>
        public int BreachedRequestCount { get; set; }

        /// <summary>
        /// SLA uyum oranı (%). Uyumlu taleplerin toplam taleplere yüzdesel oranıdır.
        /// </summary>
        public decimal SlaComplianceRate { get; set; }

        /// <summary>
        /// Taleplere yapılan ortalama ilk dönüş süresi (Dakika).
        /// </summary>
        public decimal AverageResponseMinutes { get; set; }

        /// <summary>
        /// Taleplerin tamamlanma/kapanma süresi ortalaması (Dakika).
        /// </summary>
        public decimal AverageResolutionMinutes { get; set; }

        /// <summary>
        /// Yanıt süresinin tahmin edilip edilmediği bilgisi. (FirstResponseAt alanı yerine AssignedAt/StartedAt kullanılıyorsa true döner).
        /// </summary>
        public bool IsEstimatedResponseTime { get; set; }

        /// <summary>
        /// Öncelik derecesine göre SLA uyum dağılımları listesi.
        /// </summary>
        public List<SlaPriorityComplianceDto> SlaComplianceByPriority { get; set; } = new();

        /// <summary>
        /// Departman bazlı SLA uyum ve yanıt/çözüm süreleri listesi.
        /// </summary>
        public List<SlaDepartmentComplianceDto> SlaComplianceByDepartment { get; set; } = new();

        /// <summary>
        /// En çok SLA ihlaline neden olan hizmet tanımları listesi.
        /// </summary>
        public List<SlaTopBreachedServiceDto> TopBreachingServices { get; set; } = new();
    }

    /// <summary>
    /// Öncelik seviyesine göre SLA performans özetini tutan veri modeli.
    /// </summary>
    public class SlaPriorityComplianceDto
    {
        /// <summary>
        /// Talebin öncelik derecesi (Critical, High, Normal, Low).
        /// </summary>
        public string Priority { get; set; } = string.Empty;

        /// <summary>
        /// Bu öncelik seviyesindeki toplam talep adedi.
        /// </summary>
        public int TotalRequests { get; set; }

        /// <summary>
        /// Bu öncelik seviyesinde hedeflenen SLA süresini aşan toplam talep adedi.
        /// </summary>
        public int BreachedRequests { get; set; }

        /// <summary>
        /// Bu öncelik seviyesindeki SLA uyum yüzdesi (%).
        /// </summary>
        public decimal ComplianceRate { get; set; }
    }

    /// <summary>
    /// Departman bazlı SLA performans özetini tutan veri modeli.
    /// </summary>
    public class SlaDepartmentComplianceDto
    {
        /// <summary>
        /// Departman benzersiz kimlik numarası (ID).
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Departman adı (örn. Housekeeping, Teknik Servis).
        /// </summary>
        public string DepartmentName { get; set; } = string.Empty;

        /// <summary>
        /// Bu departmana atanmış toplam talep adedi.
        /// </summary>
        public int TotalRequests { get; set; }

        /// <summary>
        /// Bu departmanda hedeflenen SLA süresini aşan toplam talep adedi.
        /// </summary>
        public int BreachedRequests { get; set; }

        /// <summary>
        /// Departmanın SLA uyum oranı (%).
        /// </summary>
        public decimal ComplianceRate { get; set; }

        /// <summary>
        /// Departmanın taleplere ortalama ilk dönüş süresi (Dakika).
        /// </summary>
        public decimal AverageResponseMinutes { get; set; }

        /// <summary>
        /// Departmanın talepleri tamamlamada harcadığı ortalama süre (Dakika).
        /// </summary>
        public decimal AverageResolutionMinutes { get; set; }
    }

    /// <summary>
    /// En çok SLA aşımına sebep olan spesifik hizmet türlerine ait veri modeli.
    /// </summary>
    public class SlaTopBreachedServiceDto
    {
        /// <summary>
        /// Hizmetin katalog veya başlık adı.
        /// </summary>
        public string ServiceName { get; set; } = string.Empty;

        /// <summary>
        /// Bu hizmette gerçekleşen toplam SLA aşım adedi.
        /// </summary>
        public int BreachCount { get; set; }

        /// <summary>
        /// Bu hizmette gerçekleşen aşımların hedef sürenin üzerindeki ortalama aşım süresi (Dakika).
        /// </summary>
        public decimal AverageBreachMinutes { get; set; }
    }
}

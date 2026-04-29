using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel ozluk dosyasindaki evrak ve belge kayitlarini tutar.
    /// </summary>
    public class EmployeeDocument : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public DocumentTypeEnum DocumentType { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public string? DocumentNumber { get; set; }
        public DateTime? IssuedAt { get; set; }
        public DateTime? ExpireAt { get; set; }
        public bool IsMandatory { get; set; }
        public int? VerifiedByEmployeeId { get; set; }
        public Employee? VerifiedByEmployee { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string? Note { get; set; }
    }
}

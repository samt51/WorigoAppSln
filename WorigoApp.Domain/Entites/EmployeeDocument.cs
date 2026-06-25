using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personel ozluk dosyasindaki evrak ve belge kayitlarini tutar.
    /// </summary>
    public class EmployeeDocument : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
/// <summary>
/// Employee değerini alır veya ayarlar.
/// </summary>
public Employee Employee { get; set; } = null!;
/// <summary>
/// DocumentType değerini alır veya ayarlar.
/// </summary>
public DocumentTypeEnum DocumentType { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// FileUrl değerini alır veya ayarlar.
/// </summary>
public string FileUrl { get; set; } = string.Empty;
/// <summary>
/// DocumentNumber değerini alır veya ayarlar.
/// </summary>
public string? DocumentNumber { get; set; }
/// <summary>
/// IssuedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? IssuedAt { get; set; }
/// <summary>
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
/// <summary>
/// IsMandatory değerini alır veya ayarlar.
/// </summary>
public bool IsMandatory { get; set; }
/// <summary>
/// VerifiedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? VerifiedByEmployeeId { get; set; }
/// <summary>
/// VerifiedByEmployee değerini alır veya ayarlar.
/// </summary>
public Employee? VerifiedByEmployee { get; set; }
/// <summary>
/// VerifiedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? VerifiedAt { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}

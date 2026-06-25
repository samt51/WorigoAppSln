using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Resepsiyon vardiyaları arasında paylaşılan, denetlenebilir devir notu.
    /// </summary>
    public class ReceptionShiftNote : EntityBase
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
/// CreatedByUserId değerini alır veya ayarlar.
/// </summary>
public int CreatedByUserId { get; set; }
/// <summary>
/// CreatedByUser değerini alır veya ayarlar.
/// </summary>
public Users CreatedByUser { get; set; } = null!;
/// <summary>
/// Content değerini alır veya ayarlar.
/// </summary>
public string Content { get; set; } = string.Empty;
/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public string Priority { get; set; } = "Normal";
/// <summary>
/// IsResolved değerini alır veya ayarlar.
/// </summary>
public bool IsResolved { get; set; }
/// <summary>
/// ResolvedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ResolvedAt { get; set; }
/// <summary>
/// ResolvedByUserId değerini alır veya ayarlar.
/// </summary>
public int? ResolvedByUserId { get; set; }
/// <summary>
/// ResolvedByUser değerini alır veya ayarlar.
/// </summary>
public Users? ResolvedByUser { get; set; }
    }
}

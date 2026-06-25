using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites;

/// <summary>
/// ReceptionCashShift sınıfını temsil eder.
/// </summary>
public class ReceptionCashShift : EntityBase
{
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// UserId değerini alır veya ayarlar.
/// </summary>
public int UserId { get; set; }
/// <summary>
/// OpenedAt değerini alır veya ayarlar.
/// </summary>
public DateTime OpenedAt { get; set; } = DateTime.UtcNow;
/// <summary>
/// ClosedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ClosedAt { get; set; }
/// <summary>
/// OpeningBalance değerini alır veya ayarlar.
/// </summary>
public decimal OpeningBalance { get; set; }
/// <summary>
/// CashIncome değerini alır veya ayarlar.
/// </summary>
public decimal CashIncome { get; set; }
/// <summary>
/// CashExpense değerini alır veya ayarlar.
/// </summary>
public decimal CashExpense { get; set; }
/// <summary>
/// CountedBalance değerini alır veya ayarlar.
/// </summary>
public decimal? CountedBalance { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Open";
/// <summary>
/// ClosingNote değerini alır veya ayarlar.
/// </summary>
public string? ClosingNote { get; set; }
/// <summary>
/// Transactions değerini alır veya ayarlar.
/// </summary>
public IList<ReceptionCashTransaction> Transactions { get; set; } = new List<ReceptionCashTransaction>();
}

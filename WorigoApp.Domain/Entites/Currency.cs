using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Currency sınıfını temsil eder.
/// </summary>
public class Currency : EntityBase
    {
/// <summary>
/// Code değerini alır veya ayarlar.
/// </summary>
public string Code { get; set; } = string.Empty;
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Symbol değerini alır veya ayarlar.
/// </summary>
public string Symbol { get; set; } = string.Empty;
/// <summary>
/// Country değerini alır veya ayarlar.
/// </summary>
public string Country { get; set; } = string.Empty;
/// <summary>
/// CultureCode değerini alır veya ayarlar.
/// </summary>
public string CultureCode { get; set; } = string.Empty;
/// <summary>
/// DecimalDigits değerini alır veya ayarlar.
/// </summary>
public int DecimalDigits { get; set; } = 2;
/// <summary>
/// IsBaseCurrency değerini alır veya ayarlar.
/// </summary>
public bool IsBaseCurrency { get; set; }
/// <summary>
/// IsSupported değerini alır veya ayarlar.
/// </summary>
public bool IsSupported { get; set; } = true;
/// <summary>
/// SortOrder değerini alır veya ayarlar.
/// </summary>
public int SortOrder { get; set; }
    }
}

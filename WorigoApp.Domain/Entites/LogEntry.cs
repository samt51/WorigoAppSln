using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// LogEntry sınıfını temsil eder.
/// </summary>
public class LogEntry :EntityBase
    {
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; }
/// <summary>
/// MessageTemplate değerini alır veya ayarlar.
/// </summary>
public string MessageTemplate { get; set; }
/// <summary>
/// Level değerini alır veya ayarlar.
/// </summary>
public string Level { get; set; }
/// <summary>
/// TimeStamp değerini alır veya ayarlar.
/// </summary>
public DateTime TimeStamp { get; set; }
/// <summary>
/// Exception değerini alır veya ayarlar.
/// </summary>
public string? Exception { get; set; }
/// <summary>
/// Properties değerini alır veya ayarlar.
/// </summary>
public string? Properties { get; set; }
/// <summary>
/// LogEvent değerini alır veya ayarlar.
/// </summary>
public string? LogEvent { get; set; }
    }
}

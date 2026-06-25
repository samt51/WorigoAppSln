namespace WorigoApp.Infrastructure.Tokens
{
    /// <summary>
    /// TokenSettings sınıfını temsil eder.
    /// </summary>
    public class TokenSettings
    {
/// <summary>
/// Audience değerini alır veya ayarlar.
/// </summary>
public string Audience { get; set; }
/// <summary>
/// Issuer değerini alır veya ayarlar.
/// </summary>
public string Issuer { get; set; }
/// <summary>
/// Secret değerini alır veya ayarlar.
/// </summary>
public string Secret { get; set; }
/// <summary>
/// TokenValidityInMunitues değerini alır veya ayarlar.
/// </summary>
public int TokenValidityInMunitues { get; set; }
    }
}

namespace WorigoApp.Application.Features.Auth.Commands.Login
{
/// <summary>
/// LoginCommandResponse sınıfını temsil eder.
/// </summary>
public class LoginCommandResponse
    {
/// <summary>
/// Token değerini alır veya ayarlar.
/// </summary>
public string Token { get; set; }
/// <summary>
/// TokenExpireDate değerini alır veya ayarlar.
/// </summary>
public DateTime TokenExpireDate { get; set; }
    }
}

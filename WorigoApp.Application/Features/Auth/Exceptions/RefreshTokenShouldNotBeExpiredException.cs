



using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// RefreshTokenShouldNotBeExpiredException sınıfını temsil eder.
/// </summary>
public class RefreshTokenShouldNotBeExpiredException : BaseException
    {
/// <summary>
/// RefreshTokenShouldNotBeExpiredException sınıfının yeni bir örneğini başlatır.
/// </summary>
public RefreshTokenShouldNotBeExpiredException() : base("Oturum süresi sona ermiştir. Lütfen tekrar giriş yapın.") { }
    }
}

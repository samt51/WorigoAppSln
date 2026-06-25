

using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// EmailOrPasswordShouldNotBeInvalidException sınıfını temsil eder.
/// </summary>
public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
/// <summary>
/// EmailOrPasswordShouldNotBeInvalidException sınıfının yeni bir örneğini başlatır.
/// </summary>
public EmailOrPasswordShouldNotBeInvalidException() : base("Kullanıcı adı veya şifre yanlıştır.") { }
       
    }

    
}

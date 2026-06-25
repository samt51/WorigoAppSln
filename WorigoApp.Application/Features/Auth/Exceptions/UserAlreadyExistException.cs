using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// UserAlreadyExistException sınıfını temsil eder.
/// </summary>
public class UserAlreadyExistException : BaseException
    {
/// <summary>
/// UserAlreadyExistException sınıfının yeni bir örneğini başlatır.
/// </summary>
public UserAlreadyExistException() : base("Böyle bir kullanıcı zaten var!") { }
    }
}

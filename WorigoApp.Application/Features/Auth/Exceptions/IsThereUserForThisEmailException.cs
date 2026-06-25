using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// IsThereUserForThisEmailException sınıfını temsil eder.
/// </summary>
public class IsThereUserForThisEmailException : BaseException
    {
/// <summary>
/// IsThereUserForThisEmailException sınıfının yeni bir örneğini başlatır.
/// </summary>
public IsThereUserForThisEmailException() : base("Bu Maile ait bir hesap bulunmuştur") { }
    }
}

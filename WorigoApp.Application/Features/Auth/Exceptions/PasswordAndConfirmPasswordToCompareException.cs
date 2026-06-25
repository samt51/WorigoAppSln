using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// PasswordAndConfirmPasswordToCompareException sınıfını temsil eder.
/// </summary>
public class PasswordAndConfirmPasswordToCompareException : BaseException
    {
/// <summary>
/// PasswordAndConfirmPasswordToCompareException sınıfının yeni bir örneğini başlatır.
/// </summary>
public PasswordAndConfirmPasswordToCompareException() : base("Şifreler Uyuşmuyor.") { }  
    }
}

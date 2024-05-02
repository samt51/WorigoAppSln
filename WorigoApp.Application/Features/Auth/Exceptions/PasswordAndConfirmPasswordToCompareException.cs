using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
    public class PasswordAndConfirmPasswordToCompareException : BaseException
    {
        public PasswordAndConfirmPasswordToCompareException() : base("Şifreler Uyuşmuyor.") { }  
    }
}

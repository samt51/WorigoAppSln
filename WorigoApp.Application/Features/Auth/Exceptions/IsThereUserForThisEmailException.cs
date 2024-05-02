using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
    public class IsThereUserForThisEmailException : BaseException
    {
        public IsThereUserForThisEmailException() : base("Bu Maile ait bir hesap bulunmuştur") { }
    }
}

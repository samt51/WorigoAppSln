using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Exceptions
{
/// <summary>
/// EmailAddressShouldBeValidException sınıfını temsil eder.
/// </summary>
public class EmailAddressShouldBeValidException : BaseException
    {
/// <summary>
/// EmailAddressShouldBeValidException sınıfının yeni bir örneğini başlatır.
/// </summary>
public EmailAddressShouldBeValidException() : base("Böyle bir email adresi bulunmamaktadır.") { }
    }
}

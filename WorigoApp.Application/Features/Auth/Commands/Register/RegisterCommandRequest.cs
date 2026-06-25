using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Register
{
/// <summary>
/// RegisterCommandRequest sınıfını temsil eder.
/// </summary>
public class RegisterCommandRequest : IRequest<ResponseDto<RegisterCommandResponse>>
    {
/// <summary>
/// RegisterCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public RegisterCommandRequest(string email, string password, string confirmPassword)
        {
            this.Email = email;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }
 
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; }
/// <summary>
/// Password değerini alır veya ayarlar.
/// </summary>
public string Password { get; }
/// <summary>
/// ConfirmPassword değerini alır veya ayarlar.
/// </summary>
public string ConfirmPassword { get; }
    }
}

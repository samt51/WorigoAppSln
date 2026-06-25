using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Login
{
/// <summary>
/// LoginCommandRequest sınıfını temsil eder.
/// </summary>
public class LoginCommandRequest : IRequest<ResponseDto<LoginCommandResponse>>
    {
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; } 
/// <summary>
/// Password değerini alır veya ayarlar.
/// </summary>
public string Password { get; } 
/// <summary>
/// LoginCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public LoginCommandRequest(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}

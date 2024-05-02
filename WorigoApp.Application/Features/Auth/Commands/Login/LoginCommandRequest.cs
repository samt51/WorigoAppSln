using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Login
{
    public class LoginCommandRequest : IRequest<Response<LoginCommandResponse>>
    {
        public string Email { get; }
        public string Password { get; }
        public LoginCommandRequest(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}

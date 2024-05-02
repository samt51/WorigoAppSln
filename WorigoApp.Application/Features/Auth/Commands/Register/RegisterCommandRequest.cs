using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandRequest : IRequest<Response<RegisterCommandResponse>>
    {
        public RegisterCommandRequest(string email, string password, string confirmPassword)
        {
            this.Email = email;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }
 
        public string Email { get; }
        public string Password { get; }
        public string ConfirmPassword { get; }
    }
}

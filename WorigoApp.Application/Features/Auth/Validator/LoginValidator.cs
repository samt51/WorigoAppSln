using FluentValidation;
using WorigoApp.Application.Features.Auth.Commands.Login;

namespace WorigoApp.Application.Features.Auth.Validator
{
    public class LoginValidator : AbstractValidator<LoginCommandRequest>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("error");
        }
    }
}

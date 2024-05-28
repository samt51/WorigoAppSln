using FluentValidation;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;

namespace WorigoApp.Application.Features.Companies.Validator
{
    public class CreateCompanyValidator : AbstractValidator<CreateCompanyCommandRequest>
    {
        public CreateCompanyValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Null().WithMessage("error1");
            RuleFor(x => x.Name).Null().WithMessage("error1");
        }
    }
}

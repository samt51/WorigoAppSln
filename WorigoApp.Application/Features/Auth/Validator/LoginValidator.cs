using FluentValidation;
using Microsoft.AspNetCore.Http;
using WorigoApp.Application.Features.Auth.Commands.Login;
using WorigoApp.Application.Helpers;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Auth.Validator
{
    public class LoginValidator : AbstractValidator<LoginCommandRequest>
    {
        private readonly GetDataFromCache _getDataFromCache;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginValidator(GetDataFromCache getDataFromCache, IHttpContextAccessor httpContextAccessor)
        {
            _getDataFromCache = getDataFromCache;
            this._httpContextAccessor = httpContextAccessor;

            var languageCode = _httpContextAccessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Accept-Language").Value;

            var cache = _getDataFromCache.GetData("validationMessage").Where(x => x.LanguageCode == languageCode);


            RuleFor(x => x.Email)
        .NotEmpty().WithMessage(cache.FirstOrDefault(x => x.ValidationMessageType == ValidationMessageType.IsNull)?.ValidationMessage)
        .EmailAddress().WithMessage(cache.FirstOrDefault(x => x.ValidationMessageType == ValidationMessageType.EmailAddressControll)
        ?.ValidationMessage);


            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(cache.FirstOrDefault
                (x => x.ValidationMessageType == ValidationMessageType.PasswordIsNull)?.ValidationMessage);
        }
    }
}

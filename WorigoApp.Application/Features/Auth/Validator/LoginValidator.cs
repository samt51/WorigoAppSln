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

            var languageCode = _httpContextAccessor.HttpContext?.Request.Headers["Accept-Language"].FirstOrDefault();
            if (string.IsNullOrWhiteSpace(languageCode))
            {
                languageCode = LanguageCodeEnum.TR;
            }

            var validationMessages = _getDataFromCache.GetData("validationMessage") ?? [];
            var cache = validationMessages.Where(x => x.LanguageCode == languageCode);

            string Message(ValidationMessageType type, string fallback)
            {
                return cache.FirstOrDefault(x => x.ValidationMessageType == type)?.ValidationMessage
                    ?? validationMessages.FirstOrDefault(x => x.LanguageCode == LanguageCodeEnum.TR && x.ValidationMessageType == type)?.ValidationMessage
                    ?? fallback;
            }


            RuleFor(x => x.Email)
        .NotEmpty().WithMessage(Message(ValidationMessageType.IsNull, "Mail alanı boş olamaz."))
        .EmailAddress().WithMessage(Message(ValidationMessageType.EmailAddressControll, "Geçerli bir email adresi giriniz."));


            RuleFor(x => x.Password)
                .NotEmpty().WithMessage(Message(ValidationMessageType.PasswordIsNull, "Şifre alanı boş olamaz."));
        }
    }
}

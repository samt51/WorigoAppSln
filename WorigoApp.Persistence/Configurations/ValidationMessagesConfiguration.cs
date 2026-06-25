using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Application.Helpers;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// ValidationMessagesConfiguration sınıfını temsil eder.
    /// </summary>
    public class ValidationMessagesConfiguration : IEntityTypeConfiguration<ValidationMessages>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<ValidationMessages> builder)
        {
            var isnullMessage = new ValidationMessages(1, Domain.Enums.ValidationMessageType.IsNull, "Mail alanı boş olamaz.", LanguageCodeEnum.TR);
            var isnullMessageUs = new ValidationMessages(2, Domain.Enums.ValidationMessageType.IsNull, "E-mail field cannot be empty.", LanguageCodeEnum.US);
            var isnullMessageEs = new ValidationMessages(3, Domain.Enums.ValidationMessageType.IsNull, "Correo electrónico el campo no puede estar vacío", LanguageCodeEnum.ES);
            var isnullMessageFr = new ValidationMessages(4, Domain.Enums.ValidationMessageType.IsNull, "E-mail le champ ne peut pas être vide.", LanguageCodeEnum.FR);
            var isnullMessageRu = new ValidationMessages(5, Domain.Enums.ValidationMessageType.IsNull, "Электронная почта поле не может быть пустым", LanguageCodeEnum.RU);
            var isnullMessageSu = new ValidationMessages(6, Domain.Enums.ValidationMessageType.IsNull, "بريد إلكتروني لا يمكن أن يكون الحقل فارغًا", LanguageCodeEnum.SA);

            var mailAddress = new ValidationMessages(7, Domain.Enums.ValidationMessageType.EmailAddressControll, "Geçerli bir email adresi giriniz.", LanguageCodeEnum.TR);
            var mailAddressUs = new ValidationMessages(8, Domain.Enums.ValidationMessageType.EmailAddressControll, "Please enter a valid email address.", LanguageCodeEnum.US);
            var mailAddressEs = new ValidationMessages(9, Domain.Enums.ValidationMessageType.EmailAddressControll, "Por favor, introduce una dirección de correo electrónico válida.", LanguageCodeEnum.ES);
            var mailAddressFr = new ValidationMessages(10, Domain.Enums.ValidationMessageType.EmailAddressControll, "S'il vous plaît, mettez une adresse email valide", LanguageCodeEnum.FR);
            var mailAddressRu = new ValidationMessages(11, Domain.Enums.ValidationMessageType.EmailAddressControll, "Пожалуйста, введите действительный адрес электронной почты", LanguageCodeEnum.RU);
            var mailAddressSu = new ValidationMessages(12, Domain.Enums.ValidationMessageType.EmailAddressControll, "يرجى إدخال عنوان بريد إلكتروني صالح", LanguageCodeEnum.SA);

            var password = new ValidationMessages(13, Domain.Enums.ValidationMessageType.PasswordIsNull, "Şifre alanı boş olamaz.", LanguageCodeEnum.TR);
            var passwordUs = new ValidationMessages(14, Domain.Enums.ValidationMessageType.PasswordIsNull, "Password cannot be empty.", LanguageCodeEnum.US);
            var passwordEs = new ValidationMessages(15, Domain.Enums.ValidationMessageType.PasswordIsNull, "La contraseña no puede estar vacía.", LanguageCodeEnum.ES);
            var passwordFr = new ValidationMessages(16, Domain.Enums.ValidationMessageType.PasswordIsNull, "Le mot de passe ne peut pas être vide.", LanguageCodeEnum.FR);
            var passwordRu = new ValidationMessages(17, Domain.Enums.ValidationMessageType.PasswordIsNull, "Пароль не может быть пустым.", LanguageCodeEnum.RU);
            var passwordSu = new ValidationMessages(18, Domain.Enums.ValidationMessageType.PasswordIsNull, "لا يمكن أن تكون كلمة المرور فارغة.", LanguageCodeEnum.SA);

            builder.HasData(isnullMessage, isnullMessageUs, isnullMessageEs, isnullMessageFr, isnullMessageRu, isnullMessageSu, mailAddress, mailAddressEs, mailAddressUs, mailAddressFr
                , mailAddressRu, mailAddressSu, password, passwordUs, passwordEs, passwordFr, passwordRu, passwordSu);
        }
    }
}

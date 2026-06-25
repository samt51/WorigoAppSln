using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ValidationMessages sınıfını temsil eder.
/// </summary>
public class ValidationMessages : IEntityBase
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ValidationMessageType değerini alır veya ayarlar.
/// </summary>
public ValidationMessageType ValidationMessageType { get; set; }
/// <summary>
/// ValidationMessage değerini alır veya ayarlar.
/// </summary>
public string ValidationMessage { get; set; }
/// <summary>
/// LanguageCode değerini alır veya ayarlar.
/// </summary>
public string LanguageCode { get; set; }
/// <summary>
/// IsDeleted değerini alır veya ayarlar.
/// </summary>
public bool IsDeleted { get; set; }
/// <summary>
/// ValidationMessages sınıfının yeni bir örneğini başlatır.
/// </summary>
public ValidationMessages()
        {

        }
/// <summary>
/// ValidationMessages sınıfının yeni bir örneğini başlatır.
/// </summary>
public ValidationMessages(int id, ValidationMessageType validationMessageType, string validationMessage, string languageCode)
        {
            this.Id = id;
            this.ValidationMessage = validationMessage;
            this.ValidationMessageType = validationMessageType;
            this.LanguageCode = languageCode;
        }
    }
}

using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class ValidationMessages : IEntityBase
    {
        public int Id { get; set; }
        public ValidationMessageType ValidationMessageType { get; set; }
        public string ValidationMessage { get; set; }
        public string LanguageCode { get; set; }
        public bool IsDeleted { get; set; }
        public ValidationMessages()
        {

        }
        public ValidationMessages(int id, ValidationMessageType validationMessageType, string validationMessage, string languageCode)
        {
            this.Id = id;
            this.ValidationMessage = validationMessage;
            this.ValidationMessageType = validationMessageType;
            this.LanguageCode = languageCode;
        }
    }
}

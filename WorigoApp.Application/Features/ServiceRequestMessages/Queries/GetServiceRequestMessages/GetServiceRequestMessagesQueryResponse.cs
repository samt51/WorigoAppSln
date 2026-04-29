using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages
{
    public class GetServiceRequestMessagesQueryResponse
    {
        public int Id { get; set; }
        public MessageSenderTypeEnum SenderType { get; set; }
        public int? SenderUserId { get; set; }
        public string OriginalLanguageCode { get; set; } = string.Empty;
        public string OriginalText { get; set; } = string.Empty;
        public string? TranslatedLanguageCode { get; set; }
        public string? TranslatedText { get; set; }
        public string TranslationStatus { get; set; } = string.Empty;
        public DateTime SentAt { get; set; }
    }
}

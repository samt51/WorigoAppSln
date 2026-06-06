namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
    public class CreateServiceRequestMessageCommandResponse
    {
        public int Id { get; set; }
        public int ServiceRequestId { get; set; }
        public int? SenderUserId { get; set; }
        public string SenderType { get; set; } = string.Empty;
        public string OriginalLanguageCode { get; set; } = string.Empty;
        public string OriginalText { get; set; } = string.Empty;
        public string? TranslatedLanguageCode { get; set; }
        public string? TranslatedText { get; set; }
        public string TranslationStatus { get; set; } = string.Empty;
        public DateTime SentAt { get; set; }
    }
}

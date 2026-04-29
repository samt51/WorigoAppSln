namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
    public class CreateServiceRequestMessageCommandResponse
    {
        public int Id { get; set; }
        public string OriginalLanguageCode { get; set; } = string.Empty;
        public string OriginalText { get; set; } = string.Empty;
        public string? TranslatedLanguageCode { get; set; }
        public string? TranslatedText { get; set; }
        public string TranslationStatus { get; set; } = string.Empty;
        public DateTime SentAt { get; set; }
    }
}

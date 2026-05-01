namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
    public class StartConversationFlowCommandResponse
    {
        public int ConversationId { get; set; }
        public int FlowSessionId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public string FlowType { get; set; } = string.Empty;
        public string CurrentStep { get; set; } = string.Empty;
        public int? OpeningMessageId { get; set; }
        public string OpeningMessage { get; set; } = string.Empty;
        public string? OpeningPayloadJson { get; set; }
    }
}

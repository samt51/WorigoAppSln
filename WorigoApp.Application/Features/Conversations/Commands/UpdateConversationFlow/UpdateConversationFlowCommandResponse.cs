namespace WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow
{
    public class UpdateConversationFlowCommandResponse
    {
        public int FlowSessionId { get; set; }
        public string CurrentStep { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}

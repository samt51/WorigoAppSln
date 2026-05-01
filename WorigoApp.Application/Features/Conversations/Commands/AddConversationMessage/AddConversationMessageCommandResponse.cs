using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage
{
    public class AddConversationMessageCommandResponse
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public ConversationMessageTypeEnum MessageType { get; set; }
        public DateTime SentAt { get; set; }
    }
}

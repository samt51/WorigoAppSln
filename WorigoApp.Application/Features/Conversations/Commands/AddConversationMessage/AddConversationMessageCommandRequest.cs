using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage
{
    public class AddConversationMessageCommandRequest : IRequest<ResponseDto<AddConversationMessageCommandResponse>>
    {
        public int ConversationId { get; set; }
        public int? SenderUserId { get; set; }
        public int? SenderCustomerId { get; set; }
        public MessageSenderTypeEnum SenderType { get; set; } = MessageSenderTypeEnum.Customer;
        public string OriginalLanguageCode { get; set; } = "tr-TR";
        public string OriginalText { get; set; } = string.Empty;
        public ConversationMessageTypeEnum MessageType { get; set; } = ConversationMessageTypeEnum.Text;
        public string? PayloadJson { get; set; }
    }
}

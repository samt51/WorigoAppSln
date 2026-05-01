using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
    public class StartConversationFlowCommandRequest : IRequest<ResponseDto<StartConversationFlowCommandResponse>>
    {
        public int GuestStayId { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public string FlowType { get; set; } = string.Empty;
        public string CurrentStep { get; set; } = "start";
        public string StateJson { get; set; } = "{}";
        public string? Subject { get; set; }
        public string LanguageCode { get; set; } = "tr-TR";
        public string OpeningMessage { get; set; } = string.Empty;
        public ConversationMessageTypeEnum OpeningMessageType { get; set; } = ConversationMessageTypeEnum.OptionList;
        public string? OpeningPayloadJson { get; set; }
    }
}

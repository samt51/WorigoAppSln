using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow
{
    public class UpdateConversationFlowCommandRequest : IRequest<ResponseDto<UpdateConversationFlowCommandResponse>>
    {
        public int FlowSessionId { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public string CurrentStep { get; set; } = string.Empty;
        public string StateJson { get; set; } = "{}";
        public bool IsCompleted { get; set; }
    }
}

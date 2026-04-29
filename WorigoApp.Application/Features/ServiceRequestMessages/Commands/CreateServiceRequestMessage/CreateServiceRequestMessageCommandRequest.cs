using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
    public class CreateServiceRequestMessageCommandRequest : IRequest<ResponseDto<CreateServiceRequestMessageCommandResponse>>
    {
        public int ServiceRequestId { get; set; }
        public int? SenderUserId { get; set; }
        public MessageSenderTypeEnum SenderType { get; set; }
        public string OriginalLanguageCode { get; set; } = "tr-TR";
        public string OriginalText { get; set; } = string.Empty;
        public string MessageType { get; set; } = "Text";
    }
}

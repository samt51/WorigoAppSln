using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
/// <summary>
/// CreateServiceRequestMessageCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestMessageCommandRequest : IRequest<ResponseDto<CreateServiceRequestMessageCommandResponse>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// SenderUserId değerini alır veya ayarlar.
/// </summary>
public int? SenderUserId { get; set; }
/// <summary>
/// SenderType değerini alır veya ayarlar.
/// </summary>
public MessageSenderTypeEnum SenderType { get; set; }
/// <summary>
/// OriginalLanguageCode değerini alır veya ayarlar.
/// </summary>
public string OriginalLanguageCode { get; set; } = "tr-TR";
/// <summary>
/// OriginalText değerini alır veya ayarlar.
/// </summary>
public string OriginalText { get; set; } = string.Empty;
/// <summary>
/// MessageType değerini alır veya ayarlar.
/// </summary>
public string MessageType { get; set; } = "Text";
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage
{
/// <summary>
/// AddConversationMessageCommandRequest sınıfını temsil eder.
/// </summary>
public class AddConversationMessageCommandRequest : IRequest<ResponseDto<AddConversationMessageCommandResponse>>
    {
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int ConversationId { get; set; }
/// <summary>
/// SenderUserId değerini alır veya ayarlar.
/// </summary>
public int? SenderUserId { get; set; }
/// <summary>
/// SenderCustomerId değerini alır veya ayarlar.
/// </summary>
public int? SenderCustomerId { get; set; }
/// <summary>
/// SenderType değerini alır veya ayarlar.
/// </summary>
public MessageSenderTypeEnum SenderType { get; set; } = MessageSenderTypeEnum.Customer;
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
public ConversationMessageTypeEnum MessageType { get; set; } = ConversationMessageTypeEnum.Text;
/// <summary>
/// PayloadJson değerini alır veya ayarlar.
/// </summary>
public string? PayloadJson { get; set; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
/// <summary>
/// StartConversationFlowCommandRequest sınıfını temsil eder.
/// </summary>
public class StartConversationFlowCommandRequest : IRequest<ResponseDto<StartConversationFlowCommandResponse>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// CustomerId değerini alır veya ayarlar.
/// </summary>
public int? CustomerId { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// FlowType değerini alır veya ayarlar.
/// </summary>
public string FlowType { get; set; } = string.Empty;
/// <summary>
/// CurrentStep değerini alır veya ayarlar.
/// </summary>
public string CurrentStep { get; set; } = "start";
/// <summary>
/// StateJson değerini alır veya ayarlar.
/// </summary>
public string StateJson { get; set; } = "{}";
/// <summary>
/// Subject değerini alır veya ayarlar.
/// </summary>
public string? Subject { get; set; }
/// <summary>
/// LanguageCode değerini alır veya ayarlar.
/// </summary>
public string LanguageCode { get; set; } = "tr-TR";
/// <summary>
/// OpeningMessage değerini alır veya ayarlar.
/// </summary>
public string OpeningMessage { get; set; } = string.Empty;
/// <summary>
/// OpeningMessageType değerini alır veya ayarlar.
/// </summary>
public ConversationMessageTypeEnum OpeningMessageType { get; set; } = ConversationMessageTypeEnum.OptionList;
/// <summary>
/// OpeningPayloadJson değerini alır veya ayarlar.
/// </summary>
public string? OpeningPayloadJson { get; set; }
    }
}

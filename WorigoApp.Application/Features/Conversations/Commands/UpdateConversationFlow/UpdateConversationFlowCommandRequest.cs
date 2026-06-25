using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow
{
/// <summary>
/// UpdateConversationFlowCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateConversationFlowCommandRequest : IRequest<ResponseDto<UpdateConversationFlowCommandResponse>>
    {
/// <summary>
/// FlowSessionId değerini alır veya ayarlar.
/// </summary>
public int FlowSessionId { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// CurrentStep değerini alır veya ayarlar.
/// </summary>
public string CurrentStep { get; set; } = string.Empty;
/// <summary>
/// StateJson değerini alır veya ayarlar.
/// </summary>
public string StateJson { get; set; } = "{}";
/// <summary>
/// IsCompleted değerini alır veya ayarlar.
/// </summary>
public bool IsCompleted { get; set; }
    }
}

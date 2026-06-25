namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
/// <summary>
/// StartConversationFlowCommandResponse sınıfını temsil eder.
/// </summary>
public class StartConversationFlowCommandResponse
    {
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int ConversationId { get; set; }
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
/// FlowType değerini alır veya ayarlar.
/// </summary>
public string FlowType { get; set; } = string.Empty;
/// <summary>
/// CurrentStep değerini alır veya ayarlar.
/// </summary>
public string CurrentStep { get; set; } = string.Empty;
/// <summary>
/// OpeningMessageId değerini alır veya ayarlar.
/// </summary>
public int? OpeningMessageId { get; set; }
/// <summary>
/// OpeningMessage değerini alır veya ayarlar.
/// </summary>
public string OpeningMessage { get; set; } = string.Empty;
/// <summary>
/// OpeningPayloadJson değerini alır veya ayarlar.
/// </summary>
public string? OpeningPayloadJson { get; set; }
    }
}

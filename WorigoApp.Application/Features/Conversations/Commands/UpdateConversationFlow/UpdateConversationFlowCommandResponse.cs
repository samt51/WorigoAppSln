namespace WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow
{
/// <summary>
/// UpdateConversationFlowCommandResponse sınıfını temsil eder.
/// </summary>
public class UpdateConversationFlowCommandResponse
    {
/// <summary>
/// FlowSessionId değerini alır veya ayarlar.
/// </summary>
public int FlowSessionId { get; set; }
/// <summary>
/// CurrentStep değerini alır veya ayarlar.
/// </summary>
public string CurrentStep { get; set; } = string.Empty;
/// <summary>
/// IsCompleted değerini alır veya ayarlar.
/// </summary>
public bool IsCompleted { get; set; }
    }
}

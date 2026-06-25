using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage
{
/// <summary>
/// AddConversationMessageCommandResponse sınıfını temsil eder.
/// </summary>
public class AddConversationMessageCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int ConversationId { get; set; }
/// <summary>
/// MessageType değerini alır veya ayarlar.
/// </summary>
public ConversationMessageTypeEnum MessageType { get; set; }
/// <summary>
/// SentAt değerini alır veya ayarlar.
/// </summary>
public DateTime SentAt { get; set; }
    }
}

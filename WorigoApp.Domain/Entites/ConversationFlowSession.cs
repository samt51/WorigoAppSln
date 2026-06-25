using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ConversationFlowSession sınıfını temsil eder.
/// </summary>
public class ConversationFlowSession : EntityBase
    {
/// <summary>
/// ConversationId değerini alır veya ayarlar.
/// </summary>
public int ConversationId { get; set; }
/// <summary>
/// Conversation değerini alır veya ayarlar.
/// </summary>
public Conversation Conversation { get; set; } = null!;

/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
/// <summary>
/// ServiceCategory değerini alır veya ayarlar.
/// </summary>
public ServiceCategory? ServiceCategory { get; set; }

/// <summary>
/// ServiceDefinitionId değerini alır veya ayarlar.
/// </summary>
public int? ServiceDefinitionId { get; set; }
/// <summary>
/// ServiceDefinition değerini alır veya ayarlar.
/// </summary>
public ServiceDefinition? ServiceDefinition { get; set; }

/// <summary>
/// FlowType değerini alır veya ayarlar.
/// </summary>
public string FlowType { get; set; } = string.Empty;
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
/// <summary>
/// StartedAt değerini alır veya ayarlar.
/// </summary>
public DateTime StartedAt { get; set; } = DateTime.UtcNow;
/// <summary>
/// CompletedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? CompletedAt { get; set; }
    }
}

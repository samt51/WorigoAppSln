using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ConversationFlowSession : EntityBase
    {
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; } = null!;

        public int? ServiceCategoryId { get; set; }
        public ServiceCategory? ServiceCategory { get; set; }

        public int? ServiceDefinitionId { get; set; }
        public ServiceDefinition? ServiceDefinition { get; set; }

        public string FlowType { get; set; } = string.Empty;
        public string CurrentStep { get; set; } = string.Empty;
        public string StateJson { get; set; } = "{}";
        public bool IsCompleted { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }
    }
}

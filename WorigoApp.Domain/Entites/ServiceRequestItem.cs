using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceRequestItem : EntityBase
    {
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;

        public int? ServiceDefinitionId { get; set; }
        public ServiceDefinition? ServiceDefinition { get; set; }

        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public string? Note { get; set; }
    }
}

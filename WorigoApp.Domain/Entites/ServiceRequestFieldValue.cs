using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceRequestFieldValue : EntityBase
    {
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;

        public int ServiceDefinitionFieldId { get; set; }
        public ServiceDefinitionField ServiceDefinitionField { get; set; } = null!;

        public string FieldKey { get; set; } = string.Empty;
        public string? Value { get; set; }
    }
}

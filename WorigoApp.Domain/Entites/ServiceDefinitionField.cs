using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class ServiceDefinitionField : EntityBase
    {
        public int ServiceDefinitionId { get; set; }
        public ServiceDefinition ServiceDefinition { get; set; } = null!;

        public string FieldKey { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string? Placeholder { get; set; }
        public ServiceDefinitionFieldTypeEnum FieldType { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public string? OptionsJson { get; set; }
        public string? ValidationRegex { get; set; }
        public string? DefaultValue { get; set; }

        public IList<ServiceRequestFieldValue> RequestValues { get; set; } = new List<ServiceRequestFieldValue>();
    }
}

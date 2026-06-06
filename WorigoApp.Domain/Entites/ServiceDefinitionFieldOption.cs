using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceDefinitionFieldOption : EntityBase
    {
        public int ServiceDefinitionFieldId { get; set; }
        public ServiceDefinitionField ServiceDefinitionField { get; set; } = null!;

        public string Value { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}

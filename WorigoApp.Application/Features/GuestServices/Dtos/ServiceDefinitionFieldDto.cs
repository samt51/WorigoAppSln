using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Dtos
{
    public class ServiceDefinitionFieldDto
    {
        public int Id { get; set; }
        public string FieldKey { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string? Placeholder { get; set; }
        public ServiceDefinitionFieldTypeEnum FieldType { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public string? OptionsJson { get; set; }
        public string? ValidationRegex { get; set; }
        public string? DefaultValue { get; set; }
    }
}

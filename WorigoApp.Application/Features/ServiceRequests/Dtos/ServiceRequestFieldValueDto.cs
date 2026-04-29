namespace WorigoApp.Application.Features.ServiceRequests.Dtos
{
    public class ServiceRequestFieldValueDto
    {
        public int ServiceDefinitionFieldId { get; set; }
        public string FieldKey { get; set; } = string.Empty;
        public string? Value { get; set; }
    }
}

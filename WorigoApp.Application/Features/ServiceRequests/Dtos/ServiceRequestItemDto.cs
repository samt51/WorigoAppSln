namespace WorigoApp.Application.Features.ServiceRequests.Dtos
{
    public class ServiceRequestItemDto
    {
        public int? ServiceDefinitionId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public string? Note { get; set; }
    }
}

using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Dtos
{
    public class ServiceDefinitionManageDto
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string? ServiceCategoryName { get; set; }
        public int? DepartmentId { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? OpeningMessage { get; set; }
        public bool IsVisibleToGuest { get; set; }
        public bool IsChargeable { get; set; }
        public bool SupportsFreeText { get; set; }
        public bool RequiresAppointment { get; set; }
        public ServiceFlowUiTypeEnum? FlowUiType { get; set; }
        public int? EstimatedDurationMinutes { get; set; }
        public int DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public bool IsActive { get; set; }
        public IList<ServiceDefinitionFieldManageDto> Fields { get; set; } = new List<ServiceDefinitionFieldManageDto>();
    }
}

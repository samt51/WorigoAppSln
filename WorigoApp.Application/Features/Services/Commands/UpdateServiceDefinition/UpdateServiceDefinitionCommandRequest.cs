using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.UpdateServiceDefinition
{
    public class UpdateServiceDefinitionCommandRequest : IRequest<ResponseDto<UpdateServiceDefinitionCommandResponse>>
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int ServiceCategoryId { get; set; }
        public int? DepartmentId { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? OpeningMessage { get; set; }
        public bool IsVisibleToGuest { get; set; } = true;
        public bool IsChargeable { get; set; }
        public bool SupportsFreeText { get; set; }
        public bool RequiresAppointment { get; set; }
        public ServiceFlowUiTypeEnum? FlowUiType { get; set; }
        public int? EstimatedDurationMinutes { get; set; }
        public int DisplayOrder { get; set; }
        public decimal Price { get; set; }
        public string CurrencyCode { get; set; } = "TRY";
        public bool IsActive { get; set; } = true;
        public IList<ServiceDefinitionFieldManageDto> Fields { get; set; } = new List<ServiceDefinitionFieldManageDto>();
    }
}

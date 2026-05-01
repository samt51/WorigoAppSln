using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Dtos;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest
{
    public class CreateServiceRequestCommandRequest : IRequest<ResponseDto<CreateServiceRequestCommandResponse>>
    {
        public int GuestStayId { get; set; }
        public int? RoomId { get; set; }
        public int? CustomerId { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public int? ServiceCatalogItemId { get; set; }
        public int? ServiceDefinitionId { get; set; }
        public int? ConversationId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string LanguageCode { get; set; } = "tr-TR";
        public ServiceRequestPriorityEnum Priority { get; set; } = ServiceRequestPriorityEnum.Normal;
        public IList<ServiceRequestFieldValueDto> FieldValues { get; set; } = new List<ServiceRequestFieldValueDto>();
        public IList<ServiceRequestItemDto> Items { get; set; } = new List<ServiceRequestItemDto>();
    }
}

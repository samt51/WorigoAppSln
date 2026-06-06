using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class ServiceDefinition : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; } = null!;

        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

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

        public IList<ServiceDefinitionField> Fields { get; set; } = new List<ServiceDefinitionField>();
        public IList<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
        public IList<ServiceRequestItem> ServiceRequestItems { get; set; } = new List<ServiceRequestItem>();
        public IList<ConversationFlowSession> FlowSessions { get; set; } = new List<ConversationFlowSession>();
    }
}

using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
    public class ToggleServiceCatalogStatusCommandResponse
    {
        public ServicesEnum ServiceType { get; set; }
        public int ServiceCatalogItemId { get; set; }
        public bool IsActive { get; set; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
    public class ToggleServiceCatalogStatusCommandRequest : IRequest<ResponseDto<ToggleServiceCatalogStatusCommandResponse>>
    {
        public int HotelId { get; set; }
        public ServicesEnum ServiceType { get; set; }
        public int ServiceCatalogItemId { get; set; }
        public bool IsActive { get; set; }
    }
}

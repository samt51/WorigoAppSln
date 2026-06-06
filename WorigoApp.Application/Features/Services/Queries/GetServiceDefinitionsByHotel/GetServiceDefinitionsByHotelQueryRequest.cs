using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceDefinitionsByHotel
{
    public class GetServiceDefinitionsByHotelQueryRequest : IRequest<ResponseDto<IList<ServiceDefinitionManageDto>>>
    {
        public int HotelId { get; set; }
        public int? ServiceCategoryId { get; set; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceCategoriesByHotel
{
    public class GetServiceCategoriesByHotelQueryRequest : IRequest<ResponseDto<IList<ServiceCategoryManageDto>>>
    {
        public int HotelId { get; set; }
    }
}

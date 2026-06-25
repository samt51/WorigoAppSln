using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceCategoriesByHotel
{
/// <summary>
/// GetServiceCategoriesByHotelQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceCategoriesByHotelQueryRequest : IRequest<ResponseDto<IList<ServiceCategoryManageDto>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}

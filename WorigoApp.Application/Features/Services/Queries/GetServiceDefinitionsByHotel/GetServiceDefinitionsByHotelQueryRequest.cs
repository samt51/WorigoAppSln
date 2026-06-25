using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceDefinitionsByHotel
{
/// <summary>
/// GetServiceDefinitionsByHotelQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceDefinitionsByHotelQueryRequest : IRequest<ResponseDto<IList<ServiceDefinitionManageDto>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// ServiceCategoryId değerini alır veya ayarlar.
/// </summary>
public int? ServiceCategoryId { get; set; }
    }
}

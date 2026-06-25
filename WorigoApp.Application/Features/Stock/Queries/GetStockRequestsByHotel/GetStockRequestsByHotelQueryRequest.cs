using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel
{
/// <summary>
/// GetStockRequestsByHotelQueryRequest sınıfını temsil eder.
/// </summary>
public class GetStockRequestsByHotelQueryRequest : IRequest<ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel
{
/// <summary>
/// GetByIdHotelQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdHotelQueryRequest : IRequest<ResponseDto<GetByIdHotelQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GetByIdHotelQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdHotelQueryRequest(int id) { HotelId = id; }
/// <summary>
/// GetByIdHotelQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdHotelQueryRequest() { }
    }
}

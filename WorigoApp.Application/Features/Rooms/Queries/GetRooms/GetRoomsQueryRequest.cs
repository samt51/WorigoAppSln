using MediatR;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
/// <summary>
/// GetRoomsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRoomsQueryRequest : IRequest<IList<GetRoomsQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GetRoomsQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRoomsQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}

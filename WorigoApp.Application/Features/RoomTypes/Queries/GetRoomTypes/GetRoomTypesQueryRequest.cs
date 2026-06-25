using MediatR;
using System.Collections.Generic;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
/// <summary>
/// GetRoomTypesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRoomTypesQueryRequest : IRequest<IList<GetRoomTypesQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// ActiveOnly değerini alır veya ayarlar.
/// </summary>
public bool? ActiveOnly { get; set; }
/// <summary>
/// GetRoomTypesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRoomTypesQueryRequest(int hotelId, bool? activeOnly = null)
        {
            HotelId = hotelId;
            ActiveOnly = activeOnly;
        }
    }
}

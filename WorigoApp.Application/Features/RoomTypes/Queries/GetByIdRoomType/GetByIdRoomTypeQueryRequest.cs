using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
/// <summary>
/// GetByIdRoomTypeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdRoomTypeQueryRequest : IRequest<ResponseDto<GetByIdRoomTypeQueryResponse>>
    {
/// <summary>
/// GetByIdRoomTypeQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdRoomTypeQueryRequest(int id)
        {
            this.Id = id;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
    }
}

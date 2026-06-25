using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
/// <summary>
/// GetByIdRoomQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdRoomQueryRequest : IRequest<ResponseDto<GetByIdRoomQueryResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// GetByIdRoomQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdRoomQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}

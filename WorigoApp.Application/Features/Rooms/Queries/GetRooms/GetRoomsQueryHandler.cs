using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
/// <summary>
/// GetRoomsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetRoomsQueryHandler : BaseHandler, IRequestHandler<GetRoomsQueryRequest, IList<GetRoomsQueryResponse>>
    {
/// <summary>
/// GetRoomsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRoomsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<IList<GetRoomsQueryResponse>> Handle(GetRoomsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<Room>().GetAllAsync();
            
            return mapper.Map<GetRoomsQueryResponse, Room>(list);
        }
    }
}

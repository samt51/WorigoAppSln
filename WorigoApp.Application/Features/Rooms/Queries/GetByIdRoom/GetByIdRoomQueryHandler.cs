using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
/// <summary>
/// GetByIdRoomQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdRoomQueryHandler : BaseHandler, IRequestHandler<GetByIdRoomQueryRequest, ResponseDto<GetByIdRoomQueryResponse>>
    {
/// <summary>
/// GetByIdRoomQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdRoomQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdRoomQueryResponse>> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Room>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdRoomQueryResponse, Room>(data);

            return new ResponseDto<GetByIdRoomQueryResponse>().Success(map);
        }
    }
}

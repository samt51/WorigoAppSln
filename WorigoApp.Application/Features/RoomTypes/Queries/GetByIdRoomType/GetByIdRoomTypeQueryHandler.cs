using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
/// <summary>
/// GetByIdRoomTypeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdRoomTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdRoomTypeQueryRequest, ResponseDto<GetByIdRoomTypeQueryResponse>>
    {
/// <summary>
/// GetByIdRoomTypeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdRoomTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdRoomTypeQueryResponse>> Handle(GetByIdRoomTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<RoomType>().GetAsync(
                predicate: x => x.Id == request.Id && !x.IsDeleted,
                include: q => q.Include(rt => rt.Rooms)
            );

            var map = mapper.Map<GetByIdRoomTypeQueryResponse, RoomType>(data);

            return new ResponseDto<GetByIdRoomTypeQueryResponse>().Success(map);
        }
    }
}

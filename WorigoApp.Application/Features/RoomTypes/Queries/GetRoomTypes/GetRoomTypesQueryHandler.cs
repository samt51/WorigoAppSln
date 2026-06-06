using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryHandler : BaseHandler, IRequestHandler<GetRoomTypesQueryRequest, IList<GetRoomTypesQueryResponse>>
    {
        public GetRoomTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetRoomTypesQueryResponse>> Handle(GetRoomTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<RoomType>().GetAllAsync(
                predicate: x => x.HotelId == request.HotelId && !x.IsDeleted && (request.ActiveOnly == null || !request.ActiveOnly.Value || x.IsActive),
                include: q => q.Include(rt => rt.Rooms)
            );

            var orderedList = list.OrderBy(rt => rt.DisplayOrder).ToList();

            var response = orderedList.Select(rt => new GetRoomTypesQueryResponse
            {
                Id = rt.Id,
                HotelId = rt.HotelId,
                Name = rt.Name,
                Description = rt.Description,
                Capacity = rt.Capacity,
                BasePrice = rt.BasePrice,
                DisplayOrder = rt.DisplayOrder,
                IsActive = rt.IsActive,
                RoomCount = rt.Rooms.Count(r => !r.IsDeleted)
            }).ToList();

            return response;
        }
    }
}

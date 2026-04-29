using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel
{
    public class GetByIdHotelQueryHandler : BaseHandler, IRequestHandler<GetByIdHotelQueryRequest, ResponseDto<GetByIdHotelQueryResponse>>
    {
        public GetByIdHotelQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdHotelQueryResponse>> Handle(GetByIdHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);

            var map = mapper.Map<GetByIdHotelQueryResponse, Hotel>(data);

            return new ResponseDto<GetByIdHotelQueryResponse>().Success(map);
        }
    }
}

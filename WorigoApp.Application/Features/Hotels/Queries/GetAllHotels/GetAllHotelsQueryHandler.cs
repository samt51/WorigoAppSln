using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
    public class GetAllHotelsQueryHandler : BaseHandler, IRequestHandler<GetAllHotelsQueryRequest, IList<GetAllHotelsQueryResponse>>
    {
        public GetAllHotelsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllHotelsQueryResponse>> Handle(GetAllHotelsQueryRequest request, CancellationToken cancellationToken)
        {
            var getHotels = await unitOfWork.GetReadRepository<Hotel>().GetAllAsync(x => x.Companyid == request.CompanyId);

            return mapper.Map<GetAllHotelsQueryResponse, Hotel>(getHotels);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQueryRequest, IList<GetAllServicesQueryResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public GetAllServicesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllServicesQueryResponse>> Handle(GetAllServicesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await _unitOfWork.GetReadRepository<Service>().GetAllAsync(x => x.HotelId == request.HotelId);

            return _mapper.Map<GetAllServicesQueryResponse, Service>(list);
        }
    }
}

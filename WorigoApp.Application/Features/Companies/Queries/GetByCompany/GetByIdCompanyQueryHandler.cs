using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Queries.GetByCompany
{
    public class GetByIdCompanyQueryHandler : BaseHandler, IRequestHandler<GetByIdCompanyQueryRequest, Response<GetByIdCompanyQueryResponse>>
    {
        public GetByIdCompanyQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdCompanyQueryResponse>> Handle(GetByIdCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.CompanyId);

            var map = mapper.Map<GetByIdCompanyQueryResponse, Company>(data);

            return new Response<GetByIdCompanyQueryResponse>().Success(map);
        }
    }
}

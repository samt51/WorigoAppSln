using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Queries.GetAllCompanies
{
    public class GetAllCompaniesQueryHandler : BaseHandler, IRequestHandler<GetAllCompaniesQueryRequest, Response<IList<GetAllCompaniesQueryResponse>>>
    {
        public GetAllCompaniesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllCompaniesQueryResponse>>> Handle(GetAllCompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var companies = await unitOfWork.GetReadRepository<Company>().GetAllAsync();

            var mapping = mapper.Map<GetAllCompaniesQueryResponse, Company>(companies);

            return new Response<IList<GetAllCompaniesQueryResponse>>().Success(mapping);

        }
    }
}

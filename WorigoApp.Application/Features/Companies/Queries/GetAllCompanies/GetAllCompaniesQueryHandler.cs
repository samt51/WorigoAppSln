using MediatR;
using Microsoft.Extensions.Logging;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Queries.GetAllCompanies
{
    public class GetAllCompaniesQueryHandler : BaseHandler, IRequestHandler<GetAllCompaniesQueryRequest, IList<GetAllCompaniesQueryResponse>>
    {
        private readonly ILogger<GetAllCompaniesQueryHandler> _logger;
        public GetAllCompaniesQueryHandler(ILogger<GetAllCompaniesQueryHandler> logger, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _logger = logger;
        }
        public async Task<IList<GetAllCompaniesQueryResponse>> Handle(GetAllCompaniesQueryRequest request, CancellationToken cancellationToken)
        {
            var companies = await unitOfWork.GetReadRepository<Company>().GetAllAsync();

            return mapper.Map<GetAllCompaniesQueryResponse, Company>(companies);
        }
    }
}

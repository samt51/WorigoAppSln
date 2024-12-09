using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;
using WorigoApp.Application.Features.Companies.Queries.GetByCompany;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Companies
{
    [Authorize(Roles = "SystemAdmin")]
    public class CompanyController : BaseController
    {
        private readonly IMediator _mediator;
        public CompanyController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        [CachingCheckAttiribute<Response<IList<GetAllCompaniesQueryResponse>>>("category")]
        public async Task<Response<IList<GetAllCompaniesQueryResponse>>> GetAllAsync()
        {
            return await this._mediator.Send(new GetAllCompaniesQueryRequest());
        }
        [HttpPost]
        [AddCachingToResponseAttirbute("category")]
        public async Task<Response<CreateCompanyCommandResponse>> AddAsync(CreateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpPost]
        [AddCachingToResponseAttirbute("category")]
        public async Task<Response<UpdateCompanyCommandResponse>> UpdateAsync(UpdateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpGet("{id}")]
        public async Task<Response<GetByIdCompanyQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdCompanyQueryRequest(id));
        }
    }
}

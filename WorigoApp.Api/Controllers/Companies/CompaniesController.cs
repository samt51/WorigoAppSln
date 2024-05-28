using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Companies
{
    [Authorize(Roles = "SystemAdmin")]
    public class CompaniesController : BaseController
    {
        private readonly IMediator _mediator;
        public CompaniesController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        [CachingCheckAttiribute<List<GetAllCompaniesQueryResponse>>("category")]

        public async Task<IList<GetAllCompaniesQueryResponse>> GetAllAsync()
        {
            return await this._mediator.Send(new GetAllCompaniesQueryRequest());
        }
        [HttpPost]
        [AddCachingToResponseAttirbute<List<GetAllCompaniesQueryResponse>>("category")]
        public async Task<Response<CreateCompanyCommandResponse>> AddAsync(CreateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpPost]
        [AddCachingToResponseAttirbute<List<GetAllCompaniesQueryResponse>>("category")]
        public async Task<Response<UpdateCompanyCommandResponse>> UpdateAsync(UpdateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
    }
}

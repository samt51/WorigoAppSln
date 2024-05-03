using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Companies
{
    [Authorize(Roles = "SystemAdmin")]
    [JwtExpirationCheck]
    [Route("[controller]/[action]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CompaniesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<GetAllCompaniesQueryResponse>> GetAllAsync()
        {
            return await this.mediator.Send(new GetAllCompaniesQueryRequest());
        }
        [HttpPost]
        public async Task<Response<CreateCompanyCommandResponse>> AddAsync(CreateCompanyCommandRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<UpdateCompanyCommandResponse>> UpdateAsync(UpdateCompanyCommandRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}

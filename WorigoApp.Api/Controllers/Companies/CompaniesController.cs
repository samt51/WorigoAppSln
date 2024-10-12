using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;

namespace WorigoApp.Api.Controllers.Companies
{
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
        public async Task<IActionResult> Get()
        {
            return Ok(await this.mediator.Send(new GetAllCompaniesQueryRequest()));

        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateCompanyCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateCompanyCommandRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}

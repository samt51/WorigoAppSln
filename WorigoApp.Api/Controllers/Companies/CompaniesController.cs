using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;

namespace WorigoApp.Api.Controllers.Companies
{
    [Authorize(Roles ="SystemAdmin")]
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
        public IActionResult Get()
        {
            return Ok(this.mediator.Send(new GetAllCompaniesQueryRequest()));
        }
        [HttpPost]
        public IActionResult Add(CreateCompanyCommandRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public IActionResult Update(UpdateCompanyCommandRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
    }
}

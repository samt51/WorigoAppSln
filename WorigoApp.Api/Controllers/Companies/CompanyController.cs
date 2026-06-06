using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Companies.Commands.CreateCompany;
using WorigoApp.Application.Features.Companies.Commands.UpdateCompany;
using WorigoApp.Application.Features.Companies.Queries.GetAllCompanies;
using WorigoApp.Application.Features.Companies.Queries.GetByCompany;

namespace WorigoApp.Api.Controllers.Companies
{
 
    public class CompanyController : BaseController
    {
        private readonly IMediator _mediator;
        public CompanyController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
 
        public async Task<ResponseDto<IList<GetAllCompaniesQueryResponse>>> GetAllAsync()
        {
            return await this._mediator.Send(new GetAllCompaniesQueryRequest());
        }
        [HttpPost]
 
        public async Task<ResponseDto<CreateCompanyCommandResponse>> AddAsync(CreateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpPost]
  
        public async Task<ResponseDto<UpdateCompanyCommandResponse>> UpdateAsync(UpdateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdCompanyQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdCompanyQueryRequest(id));
        }
    }
}

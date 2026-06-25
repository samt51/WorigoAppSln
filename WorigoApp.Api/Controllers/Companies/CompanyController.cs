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
 
/// <summary>
/// CompanyController sınıfını temsil eder.
/// </summary>
public class CompanyController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// CompanyController sınıfının yeni bir örneğini başlatır.
/// </summary>
public CompanyController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
  /// <summary>
  /// GetAllAsync işlemini gerçekleştirir.
  /// </summary>
[HttpGet]
 
        public async Task<ResponseDto<IList<GetAllCompaniesQueryResponse>>> GetAllAsync()
        {
            return await this._mediator.Send(new GetAllCompaniesQueryRequest());
        }
  /// <summary>
  /// AddAsync işlemini gerçekleştirir.
  /// </summary>
[HttpPost]
 
        public async Task<ResponseDto<CreateCompanyCommandResponse>> AddAsync(CreateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
   /// <summary>
   /// UpdateAsync işlemini gerçekleştirir.
   /// </summary>
[HttpPost]
  
        public async Task<ResponseDto<UpdateCompanyCommandResponse>> UpdateAsync(UpdateCompanyCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        /// <summary>
        /// GetByIdAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdCompanyQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdCompanyQueryRequest(id));
        }
    }
}

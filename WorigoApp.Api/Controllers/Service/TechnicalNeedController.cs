using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.AllServiceFeature.TechnicalNeeds.Queries.GetAllTechnical;

namespace WorigoApp.Api.Controllers.Service
{
    public class TechnicalNeedController : BaseController
    {
        private readonly IMediator _mediator;
        public TechnicalNeedController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<Response<IList<GetAllTechnicalQueryResponse>>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetAllTechnicalQueryRequest());
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy;
using WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies;

namespace WorigoApp.Api.Controllers.HotelServicePolicies
{
    [Authorize(Roles = "SystemAdmin,HotelAdmin")]
    public class HotelServicePolicyController : BaseController
    {
        private readonly IMediator _mediator;
        public HotelServicePolicyController(IMediator mediator) : base(mediator) { _mediator = mediator; }

        [HttpGet]
        public async Task<ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>> GetAllAsync() => await _mediator.Send(new GetHotelServicePoliciesQueryRequest());

        [HttpPost]
        public async Task<ResponseDto<UpsertHotelServicePolicyCommandResponse>> UpsertAsync(UpsertHotelServicePolicyCommandRequest request) => await _mediator.Send(request);
    }
}

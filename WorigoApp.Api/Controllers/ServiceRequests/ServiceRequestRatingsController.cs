using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating;
using WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetRatingsByServiceRequest;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.ServiceRequests
{
    [Authorize]
    public class ServiceRequestRatingsController : BaseController
    {
        private readonly IMediator _mediator;

        public ServiceRequestRatingsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Tamamlanan servis talebi icin misafir puanlama olusturur.")]
        public async Task<ResponseDto<CreateServiceRequestRatingCommandResponse>> Create(CreateServiceRequestRatingCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{serviceRequestId}")]
        [SwaggerDescriptionAttirbute("Servis talebine ait puanlamalari listeler.")]
        public async Task<ResponseDto<IList<GetRatingsByServiceRequestQueryResponse>>> GetByServiceRequest(int serviceRequestId)
        {
            return await _mediator.Send(new GetRatingsByServiceRequestQueryRequest
            {
                ServiceRequestId = serviceRequestId
            });
        }
    }
}

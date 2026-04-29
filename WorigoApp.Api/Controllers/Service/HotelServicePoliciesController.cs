using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy;
using WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies;
using WorigoApp.Application.Filters;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize]
    public class HotelServicePoliciesController : BaseController
    {
        private readonly IMediator _mediator;

        public HotelServicePoliciesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Otelin servis görünürlük, ücret ve ödeme kurallarını oluşturur veya günceller.")]
        public async Task<ResponseDto<UpsertHotelServicePolicyCommandResponse>> Upsert(UpsertHotelServicePolicyCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{hotelId}")]
        [SwaggerDescriptionAttirbute("Otele ait servis paket kurallarını listeler.")]
        public async Task<ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>> GetByHotel(int hotelId, [FromQuery] AccommodationConceptTypeEnum? accommodationConceptType)
        {
            return await _mediator.Send(new GetHotelServicePoliciesQueryRequest
            {
                HotelId = hotelId,
                AccommodationConceptType = accommodationConceptType
            });
        }
    }
}

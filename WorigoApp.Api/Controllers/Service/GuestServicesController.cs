using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategoryItems;
using WorigoApp.Application.Filters;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize]
    public class GuestServicesController : BaseController
    {
        private readonly IMediator _mediator;

        public GuestServicesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{guestStayId}")]
        [SwaggerDescriptionAttirbute("Misafirin konaklama konseptine göre görebileceği servisleri listeler.")]
        public async Task<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>> GetAvailableServices(int guestStayId)
        {
            return await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = guestStayId
            });
        }

        [HttpGet("categories/{guestStayId}")]
        [SwaggerDescriptionAttirbute("Misafirin görebileceği servis kategorilerini özet olarak listeler.")]
        public async Task<ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>> GetCategories(int guestStayId)
        {
            return await _mediator.Send(new GetGuestServiceCategoriesQueryRequest
            {
                GuestStayId = guestStayId
            });
        }

        [HttpGet("categories/{guestStayId}/{serviceType}")]
        [SwaggerDescriptionAttirbute("Seçilen servis kategorisine ait detay kayıtları listeler.")]
        public async Task<ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>> GetCategoryItems(int guestStayId, ServicesEnum serviceType)
        {
            return await _mediator.Send(new GetGuestServiceCategoryItemsQueryRequest
            {
                GuestStayId = guestStayId,
                ServiceType = serviceType
            });
        }
    }
}

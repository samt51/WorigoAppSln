using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Commands.CreateServiceCategory;
using WorigoApp.Application.Features.Services.Commands.CreateServiceDefinition;
using WorigoApp.Application.Features.Services.Commands.UpdateServiceCategory;
using WorigoApp.Application.Features.Services.Commands.UpdateServiceDefinition;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Application.Features.Services.Queries.GetServiceCategoriesByHotel;
using WorigoApp.Application.Features.Services.Queries.GetServiceDefinitionsByHotel;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin,HotelAdmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceManagementController : BaseController
    {
        private readonly IMediator _mediator;

        public ServiceManagementController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("categories/{hotelId}")]
        public async Task<ResponseDto<IList<ServiceCategoryManageDto>>> GetCategories(int hotelId)
        {
            return await _mediator.Send(new GetServiceCategoriesByHotelQueryRequest
            {
                HotelId = hotelId
            });
        }

        [HttpPost("categories")]
        public async Task<ResponseDto<CreateServiceCategoryCommandResponse>> CreateCategory(CreateServiceCategoryCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("categories/{id}")]
        public async Task<ResponseDto<UpdateServiceCategoryCommandResponse>> UpdateCategory(int id, UpdateServiceCategoryCommandRequest request)
        {
            request.Id = id;
            return await _mediator.Send(request);
        }

        [HttpGet("definitions/{hotelId}")]
        public async Task<ResponseDto<IList<ServiceDefinitionManageDto>>> GetDefinitions(int hotelId, [FromQuery] int? serviceCategoryId)
        {
            return await _mediator.Send(new GetServiceDefinitionsByHotelQueryRequest
            {
                HotelId = hotelId,
                ServiceCategoryId = serviceCategoryId
            });
        }

        [HttpPost("definitions")]
        public async Task<ResponseDto<CreateServiceDefinitionCommandResponse>> CreateDefinition(CreateServiceDefinitionCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("definitions/{id}")]
        public async Task<ResponseDto<UpdateServiceDefinitionCommandResponse>> UpdateDefinition(int id, UpdateServiceDefinitionCommandRequest request)
        {
            request.Id = id;
            return await _mediator.Send(request);
        }
    }
}

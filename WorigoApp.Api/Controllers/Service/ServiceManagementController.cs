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
    /// <summary>
    /// ServiceManagementController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin,HotelAdmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceManagementController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// ServiceManagementController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ServiceManagementController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// GetCategories işlemini gerçekleştirir.
        /// </summary>
[HttpGet("categories/{hotelId}")]
        public async Task<ResponseDto<IList<ServiceCategoryManageDto>>> GetCategories(int hotelId)
        {
            return await _mediator.Send(new GetServiceCategoriesByHotelQueryRequest
            {
                HotelId = hotelId
            });
        }

        /// <summary>
        /// CreateCategory işlemini gerçekleştirir.
        /// </summary>
[HttpPost("categories")]
        public async Task<ResponseDto<CreateServiceCategoryCommandResponse>> CreateCategory(CreateServiceCategoryCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// UpdateCategory işlemini gerçekleştirir.
        /// </summary>
[HttpPut("categories/{id}")]
        public async Task<ResponseDto<UpdateServiceCategoryCommandResponse>> UpdateCategory(int id, UpdateServiceCategoryCommandRequest request)
        {
            request.Id = id;
            return await _mediator.Send(request);
        }

        /// <summary>
        /// GetDefinitions işlemini gerçekleştirir.
        /// </summary>
[HttpGet("definitions/{hotelId}")]
        public async Task<ResponseDto<IList<ServiceDefinitionManageDto>>> GetDefinitions(int hotelId, [FromQuery] int? serviceCategoryId)
        {
            return await _mediator.Send(new GetServiceDefinitionsByHotelQueryRequest
            {
                HotelId = hotelId,
                ServiceCategoryId = serviceCategoryId
            });
        }

        /// <summary>
        /// CreateDefinition işlemini gerçekleştirir.
        /// </summary>
[HttpPost("definitions")]
        public async Task<ResponseDto<CreateServiceDefinitionCommandResponse>> CreateDefinition(CreateServiceDefinitionCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// UpdateDefinition işlemini gerçekleştirir.
        /// </summary>
[HttpPut("definitions/{id}")]
        public async Task<ResponseDto<UpdateServiceDefinitionCommandResponse>> UpdateDefinition(int id, UpdateServiceDefinitionCommandRequest request)
        {
            request.Id = id;
            return await _mediator.Send(request);
        }
    }
}

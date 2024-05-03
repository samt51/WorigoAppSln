using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class FoodCategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public FoodCategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{hotelid}")]
        public async Task<Response<IList<GetAllFoodMenuCategoriesQueryResponse>>> GetAllAsync(int hotelId)
        {
            return await this.mediator.Send(new GetAllFoodMenuCategoriesQueryRequest(hotelId));
        }
        [HttpPost]
        public async Task<Response<CreateFoodMenuCategoryCommonResponse>> AddAsync(CreateFoodMenuCategoryCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<UpdateFoodMenuCategoryCommonResponse>> UpdateAsync(UpdateFoodMenuCategoryCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}

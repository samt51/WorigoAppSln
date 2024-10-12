using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories;

namespace WorigoApp.Api.Controllers.Service
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class FoodCategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public FoodCategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("{hotelId}")]
        public async Task<IActionResult> Get(int hotelId)
        {
            return Ok(await this.mediator.Send(new GetAllFoodMenuCategoriesQueryRequest(hotelId)));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateFoodMenuCategoryCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateFoodMenuCategoryCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}

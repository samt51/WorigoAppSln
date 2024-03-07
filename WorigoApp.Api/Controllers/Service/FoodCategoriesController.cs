using MediatR;
using Microsoft.AspNetCore.Http;
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
        [HttpGet("{hotelid}")]
        public IActionResult Get(int hotelId)
        {
            return Ok(this.mediator.Send(new GetAllFoodMenuCategoriesQueryRequest(hotelId)));
        }
        [HttpPost]
        public IActionResult Post(CreateFoodMenuCategoryCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
        [HttpPost]
        public IActionResult Update(UpdateFoodMenuCategoryCommonRequest request)
        {
            return Ok(this.mediator.Send(request));
        }
    }
}

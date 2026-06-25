using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory;
using WorigoApp.Application.Features.FoodMenuCategories.Queries.GetAllFoodMenuCategories;

namespace WorigoApp.Api.Controllers.Service
{
    /// <summary>
    /// FoodCategoriesController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin")]
    public class FoodCategoriesController : BaseController
    {
        private readonly IMediator mediator;
/// <summary>
/// FoodCategoriesController sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodCategoriesController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;   
        }

        /// <summary>
        /// GetAllAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet("{hotelid}")]
        public async Task<ResponseDto<IList<GetAllFoodMenuCategoriesQueryResponse>>> GetAllAsync(int hotelId)
        {
            return await this.mediator.Send(new GetAllFoodMenuCategoriesQueryRequest(hotelId));
        }
        /// <summary>
        /// AddAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<CreateFoodMenuCategoryCommonResponse>> AddAsync(CreateFoodMenuCategoryCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        /// <summary>
        /// UpdateAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<UpdateFoodMenuCategoryCommonResponse>> UpdateAsync(UpdateFoodMenuCategoryCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}

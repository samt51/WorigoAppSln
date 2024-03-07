using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.UpdateFoodMenuCategory
{
    public class UpdateFoodMenuCategoryCommonRequest : IRequest<Response<UpdateFoodMenuCategoryCommonResponse>>
    {
        public int Id { get; }
        public string Name { get; set; }
    }
}

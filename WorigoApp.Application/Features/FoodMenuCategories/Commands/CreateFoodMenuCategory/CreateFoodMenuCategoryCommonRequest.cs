using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory
{
    public class CreateFoodMenuCategoryCommonRequest : IRequest<Response<CreateFoodMenuCategoryCommonResponse>>
    {
        public CreateFoodMenuCategoryCommonRequest(string name, int hotelid)
        {
            this.Name = name;
            this.HotelId = hotelid;
        }
        public string Name { get; }
        public int HotelId { get; }
    }
}

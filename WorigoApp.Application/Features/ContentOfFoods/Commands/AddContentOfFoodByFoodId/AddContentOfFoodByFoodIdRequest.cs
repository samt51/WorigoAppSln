using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.AddContentOfFoodByFoodId
{
    public class AddContentOfFoodByFoodIdRequest : IRequest<Response<AddContentOfFoodByFoodIdResponse>>
    {
        public int FoodId { get; }
        public int ContentsOfFoodId { get; }

        public AddContentOfFoodByFoodIdRequest(int foodId, int contentOfFoodId)
        {
            this.FoodId = foodId;
            this.ContentsOfFoodId = contentOfFoodId;
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.RemoveContentOfFoodByFoodId
{
   public class RemoveContentOfFoodByFoodIdRequest : IRequest<Response<RemoveContentOfFoodByFoodIdResponse>>    
    {
        public int FoodId { get; }
        public int ContentsOfFoodId { get; }

        public RemoveContentOfFoodByFoodIdRequest(int foodId, int contentOfFoodId)
        {
            this.FoodId = foodId;
            this.ContentsOfFoodId = contentOfFoodId;
        }
    }
}

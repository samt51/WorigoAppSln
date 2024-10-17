using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;

namespace WorigoApp.Application.Features.Foods.Commands.CreateFood
{
    public class CreateFoodCommonRequest : IRequest<Response<CreateFoodCommonResponse>>
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int FoodMenuCategoryId { get; set; }
        public List<ContentOfFoodRequestAndResponseDto> contentOfFoodRequestAndResponseDto { get; set; }
    }
}

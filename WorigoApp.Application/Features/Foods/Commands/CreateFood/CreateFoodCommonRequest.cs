using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;

namespace WorigoApp.Application.Features.Foods.Commands.CreateFood
{
    public class CreateFoodCommonRequest : IRequest<Response<CreateFoodCommonResponse>>
    {
        public CreateFoodCommonRequest(string name, decimal price, string description, int foodMenuCategoryId, List<ContentOfFoodRequestAndResponseDto> requestAndResponseDto)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.FoodMenuCategoryId = foodMenuCategoryId;
            this.contentOfFoodRequestAndResponseDto = requestAndResponseDto;
        }
        public string Name { get; }
        public decimal Price { get; }
        public string Description { get; }
        public int FoodMenuCategoryId { get; }

        public List<ContentOfFoodRequestAndResponseDto> contentOfFoodRequestAndResponseDto { get; }
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.CreateContentOfFood
{
    public class CreateContentOfFoodRequest : IRequest<Response<CreateContentOfFoodResponse>>
    {
        public string Name { get; }
        public CreateContentOfFoodRequest(string name)
        {
            this.Name = name;
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.UpdateContentOfFood
{
    public class UpdateContentOfFoodRequest : IRequest<Response<UpdateContentOfFoodResponse>>
    {
        public int Id { get; }
        public string Name { get; }
        public UpdateContentOfFoodRequest(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}

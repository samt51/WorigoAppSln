using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetByImageCategory
{
    public class GetByImageCategoryQueryRequest : IRequest<Response<GetByImageCategoryQueryResponse>>
    {
        public int Id { get; }
        public GetByImageCategoryQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}

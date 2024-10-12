using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
    public class GetAllImageCategoriesQueryHandler : BaseHandler, IRequestHandler<GetAllImageCategoriesQueryRequest, Response<IList<GetAllImageCategoriesQueryResponse>>>
    {
        public GetAllImageCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllImageCategoriesQueryResponse>>> Handle(GetAllImageCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var getImageCategories = await unitOfWork.GetReadRepository<ImageCategory>().GetAllAsync(x => x.HotelId == request.HotelId);

            var mapping = mapper.Map<GetAllImageCategoriesQueryResponse, ImageCategory>(getImageCategories);

            return new Response<IList<GetAllImageCategoriesQueryResponse>>().Success(mapping);
        }
    }
}

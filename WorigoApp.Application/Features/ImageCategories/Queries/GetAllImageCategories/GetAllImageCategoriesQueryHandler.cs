using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
    public class GetAllImageCategoriesQueryHandler : BaseHandler, IRequestHandler<GetAllImageCategoriesQueryRequest, IList<GetAllImageCategoriesQueryResponse>>
    {
        public GetAllImageCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllImageCategoriesQueryResponse>> Handle(GetAllImageCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var getImageCategories = await unitOfWork.GetReadRepository<ImageCategory>().GetAllAsync(x => x.HotelId == request.HotelId);

            return mapper.Map<GetAllImageCategoriesQueryResponse, ImageCategory>(getImageCategories);
        }
    }
}

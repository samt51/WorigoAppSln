using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
    public class GetImagesQueryHandler : BaseHandler, IRequestHandler<GetImagesQueryRequest, Response<IList<GetImagesQueryResponse>>>
    {
        public GetImagesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetImagesQueryResponse>>> Handle(GetImagesQueryRequest request, CancellationToken cancellationToken)
        {
            var images = await unitOfWork.GetReadRepository<Image>().GetAllAsync(x => x.ImageCategoryId == request.ImagesCategoryId);

            var mapping = mapper.Map<GetImagesQueryResponse, Image>(images);

            return new Response<IList<GetImagesQueryResponse>>().Success(mapping);
        }
    }
}

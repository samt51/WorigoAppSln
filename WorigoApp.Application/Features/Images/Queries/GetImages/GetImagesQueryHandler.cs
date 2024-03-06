using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
    public class GetImagesQueryHandler : BaseHandler, IRequestHandler<GetImagesQueryRequest, IList<GetImagesQueryResponse>>
    {
        public GetImagesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetImagesQueryResponse>> Handle(GetImagesQueryRequest request, CancellationToken cancellationToken)
        {
            var images = await unitOfWork.GetReadRepository<Image>().GetAllAsync(x => x.ImageCategoryId == request.ImagesCategoryId);

            return mapper.Map<GetImagesQueryResponse, Image>(images);
        }
    }
}

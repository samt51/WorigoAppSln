using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetImages
{
/// <summary>
/// GetImagesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetImagesQueryHandler : BaseHandler, IRequestHandler<GetImagesQueryRequest, IList<GetImagesQueryResponse>>
    {
/// <summary>
/// GetImagesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetImagesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<IList<GetImagesQueryResponse>> Handle(GetImagesQueryRequest request, CancellationToken cancellationToken)
        {
            var images = await unitOfWork.GetReadRepository<Image>().GetAllAsync(x => x.ImageCategoryId == request.ImagesCategoryId);

            return mapper.Map<GetImagesQueryResponse, Image>(images);
        }
    }
}

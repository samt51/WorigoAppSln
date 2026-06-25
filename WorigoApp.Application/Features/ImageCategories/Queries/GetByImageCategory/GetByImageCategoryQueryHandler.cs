using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetByImageCategory
{
/// <summary>
/// GetByImageCategoryQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByImageCategoryQueryHandler : BaseHandler, IRequestHandler<GetByImageCategoryQueryRequest, ResponseDto<GetByImageCategoryQueryResponse>>
    {
/// <summary>
/// GetByImageCategoryQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByImageCategoryQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByImageCategoryQueryResponse>> Handle(GetByImageCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ImageCategory>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByImageCategoryQueryResponse, ImageCategory>(data);

            return new ResponseDto<GetByImageCategoryQueryResponse>().Success(map);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Commands.CreateImageCategory
{
/// <summary>
/// UpdateImageCategoryCommonHandler sınıfını temsil eder.
/// </summary>
public class UpdateImageCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateImageCategoryCommonRequest, ResponseDto<UpdateImageCategoryCommonResponse>>
    {
/// <summary>
/// UpdateImageCategoryCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateImageCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateImageCategoryCommonResponse>> Handle(UpdateImageCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            var entityMap = mapper.Map<ImageCategory, UpdateImageCategoryCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<ImageCategory>().AddAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateImageCategoryCommonResponse>().Success();

        }
    }
}

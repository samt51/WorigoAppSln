using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Commands.UpdateImageCategory
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

            var entityMap = mapper.Map<ImageCategory, UpdateImageCategoryCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<ImageCategory>().UpdateAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();
            
            return new ResponseDto<UpdateImageCategoryCommonResponse>().Success();
        }
    }
}

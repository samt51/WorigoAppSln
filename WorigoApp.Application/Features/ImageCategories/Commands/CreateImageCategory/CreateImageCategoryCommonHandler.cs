using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Commands.CreateImageCategory
{
    public class UpdateImageCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateImageCategoryCommonRequest, ResponseDto<UpdateImageCategoryCommonResponse>>
    {
        public UpdateImageCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

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

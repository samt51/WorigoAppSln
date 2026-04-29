using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Commands.CreateImage
{
    public class UpdateImageCommonHandler : BaseHandler, IRequestHandler<UpdateImageCommonRequest, ResponseDto<CreateImageCommonResponse>>
    {
        public UpdateImageCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateImageCommonResponse>> Handle(UpdateImageCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<ImageCategory>().GetAsync(x => x.Id == request.ImageCategoryId && !x.IsDeleted);

            var entityMap = mapper.Map<Image, UpdateImageCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<Image>().AddAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateImageCommonResponse>().Success();
        }
    }
}

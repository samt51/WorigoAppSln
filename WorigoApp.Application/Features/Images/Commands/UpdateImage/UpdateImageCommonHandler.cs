using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Commands.UpdateImage
{
    public class UpdateImageCommonHandler : BaseHandler, IRequestHandler<UpdateImageCommonRequest, ResponseDto<UpdateImageCommonResponse>>
    {
        public UpdateImageCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateImageCommonResponse>> Handle(UpdateImageCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Image>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var entityMap = mapper.Map<Image, UpdateImageCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<Image>().UpdateAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateImageCommonResponse>().Success();

        }
    }
}

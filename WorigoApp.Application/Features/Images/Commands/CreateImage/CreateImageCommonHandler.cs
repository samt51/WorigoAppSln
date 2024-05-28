using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Commands.CreateImage
{
    public class UpdateImageCommonHandler : BaseHandler, IRequestHandler<UpdateImageCommonRequest, Response<CreateImageCommonResponse>>
    {
        public UpdateImageCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateImageCommonResponse>> Handle(UpdateImageCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<ImageCategory>().GetAsync(x => x.Id == request.ImageCategoryId && !x.IsDeleted);

            var entityMap = mapper.Map<Image, UpdateImageCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<Image>().AddAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateImageCommonResponse>().Success();
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Commands.UpdateImage
{
    public class UpdateImageCommonHandler : BaseHandler, IRequestHandler<UpdateImageCommonRequest, Response<UpdateImageCommonResponse>>
    {
        public UpdateImageCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateImageCommonResponse>> Handle(UpdateImageCommonRequest request, CancellationToken cancellationToken)
        {
            var imageIsControll = await unitOfWork.GetReadRepository<Image>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if (imageIsControll is null)
            {
                return new Response<UpdateImageCommonResponse>().Fail(new UpdateImageCommonResponse(), "Image Is Undifined", 400);
            }

            var entityMap = mapper.Map<Image, UpdateImageCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<Image>().UpdateAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateImageCommonResponse>().Success();
            }
            return new Response<UpdateImageCommonResponse>().Fail(new UpdateImageCommonResponse(), "", 400);
        }
    }
}

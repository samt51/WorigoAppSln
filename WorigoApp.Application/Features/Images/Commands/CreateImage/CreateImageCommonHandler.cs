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
            var imageCategoryIsControll = await unitOfWork.GetReadRepository<ImageCategory>().GetAsync(x => x.Id == request.ImageCategoryId && !x.IsDeleted);

            if (imageCategoryIsControll is null)
            {
                return new Response<CreateImageCommonResponse>().Fail(new CreateImageCommonResponse(), "Category Is Undifined", 400);
            }

            var entityMap = mapper.Map<Image, UpdateImageCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<Image>().AddAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<CreateImageCommonResponse>().Success();
            }
            return new Response<CreateImageCommonResponse>().Fail(new CreateImageCommonResponse(), "", 400);
        }
    }
}

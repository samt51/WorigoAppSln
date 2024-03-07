using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Commands.UpdateImageCategory
{
    public class UpdateImageCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateImageCategoryCommonRequest, Response<UpdateImageCategoryCommonResponse>>
    {
        public UpdateImageCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateImageCategoryCommonResponse>> Handle(UpdateImageCategoryCommonRequest request, CancellationToken cancellationToken)
        {
             
            var entityMap = mapper.Map<ImageCategory, UpdateImageCategoryCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<ImageCategory>().UpdateAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateImageCategoryCommonResponse>().Success();
            }
            return new Response<UpdateImageCategoryCommonResponse>().Fail(new UpdateImageCategoryCommonResponse(), "", 400);
        }
    }
}

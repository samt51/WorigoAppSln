using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ImageCategories.Commands.CreateImageCategory
{
    public class UpdateImageCategoryCommonHandler : BaseHandler, IRequestHandler<UpdateImageCategoryCommonRequest, Response<UpdateImageCategoryCommonResponse>>
    {
        public UpdateImageCategoryCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateImageCategoryCommonResponse>> Handle(UpdateImageCategoryCommonRequest request, CancellationToken cancellationToken)
        {
            var hotelIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            if (hotelIsControll is null)
            {
                return new Response<UpdateImageCategoryCommonResponse>().Fail(new UpdateImageCategoryCommonResponse(), "Hotel Is Undifined", 400);
            }
            var entityMap = mapper.Map<ImageCategory, UpdateImageCategoryCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<ImageCategory>().AddAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateImageCategoryCommonResponse>().Success();
            }
            return new Response<UpdateImageCategoryCommonResponse>().Fail(new UpdateImageCategoryCommonResponse(), "", 400);
        }
    }
}

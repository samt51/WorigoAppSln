using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.UpdateServiceCategory
{
    public class UpdateServiceCategoryCommandHandler : BaseHandler, IRequestHandler<UpdateServiceCategoryCommandRequest, ResponseDto<UpdateServiceCategoryCommandResponse>>
    {
        public UpdateServiceCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateServiceCategoryCommandResponse>> Handle(UpdateServiceCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await unitOfWork.GetReadRepository<ServiceCategory>()
                .GetAsync(x => x.Id == request.Id && x.HotelId == request.HotelId && !x.IsDeleted, enableTracking: true);

            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.IconUrl = request.IconUrl;
            entity.IconKey = request.IconKey;
            entity.DisplayOrder = request.DisplayOrder;
            entity.ShowOnHome = request.ShowOnHome;
            entity.IsPopular = request.IsPopular;
            entity.HomeDisplayOrder = request.HomeDisplayOrder;
            entity.LegacyServiceType = request.LegacyServiceType;
            entity.IsActive = request.IsActive;
            entity.ModifyDate = DateTime.UtcNow;

            await unitOfWork.GetWriteRepository<ServiceCategory>().UpdateAsync(entity);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateServiceCategoryCommandResponse>().Success(new UpdateServiceCategoryCommandResponse
            {
                Id = entity.Id
            });
        }
    }
}

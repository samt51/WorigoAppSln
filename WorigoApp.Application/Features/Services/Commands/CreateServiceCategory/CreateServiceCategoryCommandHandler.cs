using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.CreateServiceCategory
{
    public class CreateServiceCategoryCommandHandler : BaseHandler, IRequestHandler<CreateServiceCategoryCommandRequest, ResponseDto<CreateServiceCategoryCommandResponse>>
    {
        public CreateServiceCategoryCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateServiceCategoryCommandResponse>> Handle(CreateServiceCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>()
                .GetAsync(x => x.Id == request.HotelId && x.IsActive && !x.IsDeleted);

            var entity = await unitOfWork.GetWriteRepository<ServiceCategory>().AddAsync(new ServiceCategory
            {
                HotelId = request.HotelId,
                Name = request.Name,
                Description = request.Description,
                IconUrl = request.IconUrl,
                IconKey = request.IconKey,
                DisplayOrder = request.DisplayOrder,
                ShowOnHome = request.ShowOnHome,
                IsPopular = request.IsPopular,
                HomeDisplayOrder = request.HomeDisplayOrder,
                LegacyServiceType = request.LegacyServiceType
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateServiceCategoryCommandResponse>().Success(new CreateServiceCategoryCommandResponse
            {
                Id = entity.Id
            });
        }
    }
}

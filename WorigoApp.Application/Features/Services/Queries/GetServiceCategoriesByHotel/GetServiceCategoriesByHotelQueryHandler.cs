using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceCategoriesByHotel
{
/// <summary>
/// GetServiceCategoriesByHotelQueryHandler sınıfını temsil eder.
/// </summary>
public class GetServiceCategoriesByHotelQueryHandler : BaseHandler, IRequestHandler<GetServiceCategoriesByHotelQueryRequest, ResponseDto<IList<ServiceCategoryManageDto>>>
    {
/// <summary>
/// GetServiceCategoriesByHotelQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetServiceCategoriesByHotelQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<ServiceCategoryManageDto>>> Handle(GetServiceCategoriesByHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await unitOfWork.GetReadRepository<ServiceCategory>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                orderBy: x => x.OrderBy(y => y.DisplayOrder).ThenBy(y => y.Name));

            var response = categories.Select(x => new ServiceCategoryManageDto
            {
                Id = x.Id,
                HotelId = x.HotelId,
                Name = x.Name,
                Description = x.Description,
                IconUrl = x.IconUrl,
                IconKey = x.IconKey,
                DisplayOrder = x.DisplayOrder,
                ShowOnHome = x.ShowOnHome,
                IsPopular = x.IsPopular,
                HomeDisplayOrder = x.HomeDisplayOrder,
                LegacyServiceType = x.LegacyServiceType,
                IsActive = x.IsActive
            }).ToList();

            return new ResponseDto<IList<ServiceCategoryManageDto>>().Success(response);
        }
    }
}

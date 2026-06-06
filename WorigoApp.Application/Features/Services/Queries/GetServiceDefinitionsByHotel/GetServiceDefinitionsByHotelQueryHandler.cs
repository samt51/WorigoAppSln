using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Queries.GetServiceDefinitionsByHotel
{
    public class GetServiceDefinitionsByHotelQueryHandler : BaseHandler, IRequestHandler<GetServiceDefinitionsByHotelQueryRequest, ResponseDto<IList<ServiceDefinitionManageDto>>>
    {
        public GetServiceDefinitionsByHotelQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<ServiceDefinitionManageDto>>> Handle(GetServiceDefinitionsByHotelQueryRequest request, CancellationToken cancellationToken)
        {
            var definitions = await unitOfWork.GetReadRepository<ServiceDefinition>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     (!request.ServiceCategoryId.HasValue || x.ServiceCategoryId == request.ServiceCategoryId.Value),
                include: query => query
                    .Include(x => x.ServiceCategory)
                    .Include(x => x.Fields),
                orderBy: x => x.OrderBy(y => y.ServiceCategory.DisplayOrder).ThenBy(y => y.DisplayOrder).ThenBy(y => y.Name));

            var response = definitions.Select(x => new ServiceDefinitionManageDto
            {
                Id = x.Id,
                HotelId = x.HotelId,
                ServiceCategoryId = x.ServiceCategoryId,
                ServiceCategoryName = x.ServiceCategory.Name,
                DepartmentId = x.DepartmentId,
                ServiceType = x.ServiceType,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                OpeningMessage = x.OpeningMessage,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                SupportsFreeText = x.SupportsFreeText,
                RequiresAppointment = x.RequiresAppointment,
                FlowUiType = x.FlowUiType,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                CurrencyCode = x.CurrencyCode,
                IsActive = x.IsActive,
                Fields = x.Fields
                    .Where(field => !field.IsDeleted)
                    .OrderBy(field => field.DisplayOrder)
                    .Select(field => new ServiceDefinitionFieldManageDto
                    {
                        Id = field.Id,
                        FieldKey = field.FieldKey,
                        Label = field.Label,
                        Placeholder = field.Placeholder,
                        FieldType = field.FieldType,
                        IsRequired = field.IsRequired,
                        DisplayOrder = field.DisplayOrder,
                        OptionsJson = field.OptionsJson,
                        ValidationRegex = field.ValidationRegex,
                        DefaultValue = field.DefaultValue
                    })
                    .ToList()
            }).ToList();

            return new ResponseDto<IList<ServiceDefinitionManageDto>>().Success(response);
        }
    }
}

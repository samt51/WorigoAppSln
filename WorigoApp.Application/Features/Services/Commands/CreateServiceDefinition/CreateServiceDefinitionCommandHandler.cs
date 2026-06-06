using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.CreateServiceDefinition
{
    public class CreateServiceDefinitionCommandHandler : BaseHandler, IRequestHandler<CreateServiceDefinitionCommandRequest, ResponseDto<CreateServiceDefinitionCommandResponse>>
    {
        public CreateServiceDefinitionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateServiceDefinitionCommandResponse>> Handle(CreateServiceDefinitionCommandRequest request, CancellationToken cancellationToken)
        {
            await ValidateReferencesAsync(request.HotelId, request.ServiceCategoryId, request.DepartmentId);
            ValidateFields(request.Fields);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var definition = await unitOfWork.GetWriteRepository<ServiceDefinition>().AddAsync(new ServiceDefinition
            {
                HotelId = request.HotelId,
                ServiceCategoryId = request.ServiceCategoryId,
                DepartmentId = request.DepartmentId,
                ServiceType = request.ServiceType,
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                OpeningMessage = request.OpeningMessage,
                IsVisibleToGuest = request.IsVisibleToGuest,
                IsChargeable = request.IsChargeable,
                SupportsFreeText = request.SupportsFreeText,
                RequiresAppointment = request.RequiresAppointment,
                FlowUiType = request.FlowUiType,
                EstimatedDurationMinutes = request.EstimatedDurationMinutes,
                DisplayOrder = request.DisplayOrder,
                Price = request.Price,
                CurrencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode) ? "TRY" : request.CurrencyCode
            });

            await unitOfWork.SaveAsync(cancellationToken);

            foreach (var field in request.Fields.OrderBy(x => x.DisplayOrder))
            {
                await unitOfWork.GetWriteRepository<ServiceDefinitionField>().AddAsync(ToField(definition.Id, field));
            }

            if (request.Fields.Any())
            {
                await unitOfWork.SaveAsync(cancellationToken);
            }

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceDefinitionCommandResponse>().Success(new CreateServiceDefinitionCommandResponse
            {
                Id = definition.Id
            });
        }

        private async Task ValidateReferencesAsync(int hotelId, int serviceCategoryId, int? departmentId)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == hotelId && x.IsActive && !x.IsDeleted);
            await unitOfWork.GetReadRepository<ServiceCategory>().GetAsync(x => x.Id == serviceCategoryId && x.HotelId == hotelId && x.IsActive && !x.IsDeleted);

            if (departmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == departmentId.Value && x.HotelId == hotelId && x.IsActive && !x.IsDeleted);
            }
        }

        private static void ValidateFields(IList<ServiceDefinitionFieldManageDto> fields)
        {
            var duplicateKey = fields
                .Where(x => !string.IsNullOrWhiteSpace(x.FieldKey))
                .GroupBy(x => x.FieldKey.Trim(), StringComparer.OrdinalIgnoreCase)
                .FirstOrDefault(x => x.Count() > 1);

            if (duplicateKey is not null)
            {
                throw new Exception($"Ayni alan anahtari birden fazla kullanilamaz: {duplicateKey.Key}");
            }
        }

        private static ServiceDefinitionField ToField(int serviceDefinitionId, ServiceDefinitionFieldManageDto field)
        {
            return new ServiceDefinitionField
            {
                ServiceDefinitionId = serviceDefinitionId,
                FieldKey = field.FieldKey.Trim(),
                Label = field.Label,
                Placeholder = field.Placeholder,
                FieldType = field.FieldType,
                IsRequired = field.IsRequired,
                DisplayOrder = field.DisplayOrder,
                OptionsJson = field.OptionsJson,
                ValidationRegex = field.ValidationRegex,
                DefaultValue = field.DefaultValue
            };
        }
    }
}

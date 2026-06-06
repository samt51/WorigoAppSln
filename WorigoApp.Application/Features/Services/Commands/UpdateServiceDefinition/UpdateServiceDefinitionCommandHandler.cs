using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.UpdateServiceDefinition
{
    public class UpdateServiceDefinitionCommandHandler : BaseHandler, IRequestHandler<UpdateServiceDefinitionCommandRequest, ResponseDto<UpdateServiceDefinitionCommandResponse>>
    {
        public UpdateServiceDefinitionCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateServiceDefinitionCommandResponse>> Handle(UpdateServiceDefinitionCommandRequest request, CancellationToken cancellationToken)
        {
            var definition = await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAsync(
                    x => x.Id == request.Id && x.HotelId == request.HotelId && !x.IsDeleted,
                    include: query => query.Include(x => x.Fields),
                    enableTracking: true);

            await ValidateReferencesAsync(request.HotelId, request.ServiceCategoryId, request.DepartmentId);
            ValidateFields(request.Fields);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            definition.ServiceCategoryId = request.ServiceCategoryId;
            definition.DepartmentId = request.DepartmentId;
            definition.ServiceType = request.ServiceType;
            definition.Name = request.Name;
            definition.Description = request.Description;
            definition.ImageUrl = request.ImageUrl;
            definition.OpeningMessage = request.OpeningMessage;
            definition.IsVisibleToGuest = request.IsVisibleToGuest;
            definition.IsChargeable = request.IsChargeable;
            definition.SupportsFreeText = request.SupportsFreeText;
            definition.RequiresAppointment = request.RequiresAppointment;
            definition.FlowUiType = request.FlowUiType;
            definition.EstimatedDurationMinutes = request.EstimatedDurationMinutes;
            definition.DisplayOrder = request.DisplayOrder;
            definition.Price = request.Price;
            definition.CurrencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode) ? "TRY" : request.CurrencyCode;
            definition.IsActive = request.IsActive;
            definition.ModifyDate = DateTime.UtcNow;

            await unitOfWork.GetWriteRepository<ServiceDefinition>().UpdateAsync(definition);
            await SyncFieldsAsync(definition, request.Fields, cancellationToken);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<UpdateServiceDefinitionCommandResponse>().Success(new UpdateServiceDefinitionCommandResponse
            {
                Id = definition.Id
            });
        }

        private async Task ValidateReferencesAsync(int hotelId, int serviceCategoryId, int? departmentId)
        {
            await unitOfWork.GetReadRepository<ServiceCategory>().GetAsync(x => x.Id == serviceCategoryId && x.HotelId == hotelId && x.IsActive && !x.IsDeleted);

            if (departmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == departmentId.Value && x.HotelId == hotelId && x.IsActive && !x.IsDeleted);
            }
        }

        private async Task SyncFieldsAsync(ServiceDefinition definition, IList<ServiceDefinitionFieldManageDto> submittedFields, CancellationToken cancellationToken)
        {
            var submittedIds = submittedFields.Where(x => x.Id.HasValue).Select(x => x.Id!.Value).ToHashSet();
            var submittedKeys = submittedFields.Select(x => x.FieldKey.Trim()).ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var existingField in definition.Fields.Where(x => !x.IsDeleted))
            {
                if (!submittedIds.Contains(existingField.Id) && !submittedKeys.Contains(existingField.FieldKey))
                {
                    existingField.IsDeleted = true;
                    existingField.IsActive = false;
                    existingField.ModifyDate = DateTime.UtcNow;
                    await unitOfWork.GetWriteRepository<ServiceDefinitionField>().UpdateAsync(existingField);
                }
            }

            foreach (var submittedField in submittedFields.OrderBy(x => x.DisplayOrder))
            {
                var existingField = definition.Fields.FirstOrDefault(x =>
                    (submittedField.Id.HasValue && x.Id == submittedField.Id.Value) ||
                    x.FieldKey.Equals(submittedField.FieldKey.Trim(), StringComparison.OrdinalIgnoreCase));

                if (existingField is null)
                {
                    await unitOfWork.GetWriteRepository<ServiceDefinitionField>().AddAsync(ToField(definition.Id, submittedField));
                    continue;
                }

                existingField.FieldKey = submittedField.FieldKey.Trim();
                existingField.Label = submittedField.Label;
                existingField.Placeholder = submittedField.Placeholder;
                existingField.FieldType = submittedField.FieldType;
                existingField.IsRequired = submittedField.IsRequired;
                existingField.DisplayOrder = submittedField.DisplayOrder;
                existingField.OptionsJson = submittedField.OptionsJson;
                existingField.ValidationRegex = submittedField.ValidationRegex;
                existingField.DefaultValue = submittedField.DefaultValue;
                existingField.IsActive = true;
                existingField.IsDeleted = false;
                existingField.ModifyDate = DateTime.UtcNow;

                await unitOfWork.GetWriteRepository<ServiceDefinitionField>().UpdateAsync(existingField);
            }

            await unitOfWork.SaveAsync(cancellationToken);
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

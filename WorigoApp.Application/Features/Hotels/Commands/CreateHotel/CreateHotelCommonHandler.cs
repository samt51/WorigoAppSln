using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommonHandler : BaseHandler, IRequestHandler<CreateHotelCommonRequest, ResponseDto<CreateHotelCommonResponse>>
    {
        private const int TemplateHotelId = 1;

        public CreateHotelCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateHotelCommonResponse>> Handle(CreateHotelCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Companyid && !x.IsDeleted);

            var mapEntity = mapper.Map<Hotel, CreateHotelCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var createdHotel = await unitOfWork.GetWriteRepository<Hotel>().AddAsync(mapEntity);
            await unitOfWork.SaveAsync(cancellationToken);

            await CloneTemplateDataAsync(createdHotel.Id, cancellationToken);

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateHotelCommonResponse>().Success();
        }

        private async Task CloneTemplateDataAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateShifts = await unitOfWork.GetReadRepository<Shift>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedShifts = templateShifts.Select(x => new Shift
            {
                Name = x.Name,
                StartTime = x.StartTime,
                EndTime = x.EndTime,
                HotelId = hotelId,
                Description = x.Description,
                IsNightShift = x.IsNightShift,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<Shift>().AddRangeAsync(clonedShifts);
            await unitOfWork.SaveAsync(cancellationToken);

            var templateDepartments = await unitOfWork.GetReadRepository<Department>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedDepartments = templateDepartments.Select(x => new Department
            {
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                DisplayOrder = x.DisplayOrder,
                IsGuestFacing = x.IsGuestFacing,
                HotelId = hotelId,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<Department>().AddRangeAsync(clonedDepartments);
            await unitOfWork.SaveAsync(cancellationToken);

            var departmentMap = templateDepartments.Zip(clonedDepartments, (oldDep, newDep) => new { oldDep.Id, NewId = newDep.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateEmployeeTypes = await unitOfWork.GetReadRepository<EmployeeType>()
                .GetAllAsync(x => templateDepartments.Select(y => y.Id).Contains(x.DepartmentId) && !x.IsDeleted);

            var clonedEmployeeTypes = templateEmployeeTypes.Select(x => new EmployeeType
            {
                Name = x.Name,
                DepartmentId = departmentMap[x.DepartmentId],
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<EmployeeType>().AddRangeAsync(clonedEmployeeTypes);
            await unitOfWork.SaveAsync(cancellationToken);

            var employeeTypeMap = templateEmployeeTypes.Zip(clonedEmployeeTypes, (oldType, newType) => new { oldType.Id, NewId = newType.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateAssignments = await unitOfWork.GetReadRepository<ServiceRoleAssignments>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedAssignments = templateAssignments.Select(x => new ServiceRoleAssignments
            {
                HotelId = hotelId,
                DepartmentId = x.DepartmentId.HasValue && departmentMap.ContainsKey(x.DepartmentId.Value) ? departmentMap[x.DepartmentId.Value] : null,
                EmployeeTypeRoleId = employeeTypeMap.ContainsKey(x.EmployeeTypeRoleId) ? employeeTypeMap[x.EmployeeTypeRoleId] : x.EmployeeTypeRoleId,
                ServiceId = x.ServiceId,
                ServicesEnumId = x.ServicesEnumId,
                IsPrimaryAssignment = x.IsPrimaryAssignment,
                Priority = x.Priority,
                SlaMinutes = x.SlaMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<ServiceRoleAssignments>().AddRangeAsync(clonedAssignments);
            await unitOfWork.SaveAsync(cancellationToken);

            await CloneServiceCatalogAsync(hotelId, departmentMap, cancellationToken);
            await CloneAnnouncementTemplatesAsync(hotelId, cancellationToken);
        }

        private async Task CloneServiceCatalogAsync(
            int hotelId,
            IReadOnlyDictionary<int, int> departmentMap,
            CancellationToken cancellationToken)
        {
            var templateCategories = await unitOfWork.GetReadRepository<ServiceCategory>()
                .GetAllAsync(
                    x => x.HotelId == TemplateHotelId && !x.IsDeleted,
                    orderBy: query => query.OrderBy(x => x.DisplayOrder));

            var clonedCategories = templateCategories.Select(x => new ServiceCategory
            {
                HotelId = hotelId,
                Name = x.Name,
                Description = x.Description,
                IconUrl = x.IconUrl,
                IconKey = x.IconKey,
                DisplayOrder = x.DisplayOrder,
                ShowOnHome = x.ShowOnHome,
                IsPopular = x.IsPopular,
                HomeDisplayOrder = x.HomeDisplayOrder,
                LegacyServiceType = x.LegacyServiceType,
                IsActive = true
            }).ToList();

            await unitOfWork.GetWriteRepository<ServiceCategory>().AddRangeAsync(clonedCategories);
            await unitOfWork.SaveAsync(cancellationToken);

            var categoryMap = templateCategories.Zip(clonedCategories, (oldCategory, newCategory) => new { oldCategory.Id, NewId = newCategory.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateDefinitions = await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAllAsync(
                    x => x.HotelId == TemplateHotelId && !x.IsDeleted,
                    include: query => query.Include(x => x.Fields).ThenInclude(field => field.Options),
                    orderBy: query => query.OrderBy(x => x.DisplayOrder));

            var clonedDefinitions = templateDefinitions.Select(x => new ServiceDefinition
            {
                HotelId = hotelId,
                ServiceCategoryId = categoryMap[x.ServiceCategoryId],
                DepartmentId = x.DepartmentId.HasValue && departmentMap.ContainsKey(x.DepartmentId.Value) ? departmentMap[x.DepartmentId.Value] : null,
                ServiceType = x.ServiceType,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                OpeningMessage = x.OpeningMessage,
                IsVisibleToGuest = true,
                IsChargeable = x.IsChargeable,
                SupportsFreeText = x.SupportsFreeText,
                RequiresAppointment = x.RequiresAppointment,
                FlowUiType = x.FlowUiType,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                CurrencyCode = x.CurrencyCode,
                IsActive = true
            }).ToList();

            await unitOfWork.GetWriteRepository<ServiceDefinition>().AddRangeAsync(clonedDefinitions);
            await unitOfWork.SaveAsync(cancellationToken);

            var definitionMap = templateDefinitions.Zip(clonedDefinitions, (oldDefinition, newDefinition) => new { oldDefinition.Id, NewId = newDefinition.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateFields = templateDefinitions
                .SelectMany(x => x.Fields.Where(field => !field.IsDeleted))
                .OrderBy(x => x.ServiceDefinitionId)
                .ThenBy(x => x.DisplayOrder)
                .ToList();

            var clonedFields = templateFields
                .Select(x => new ServiceDefinitionField
                {
                    ServiceDefinitionId = definitionMap[x.ServiceDefinitionId],
                    FieldKey = x.FieldKey,
                    Label = x.Label,
                    Placeholder = x.Placeholder,
                    FieldType = x.FieldType,
                    IsRequired = x.IsRequired,
                    DisplayOrder = x.DisplayOrder,
                    OptionsJson = x.OptionsJson,
                    ValidationRegex = x.ValidationRegex,
                    DefaultValue = x.DefaultValue,
                    IsActive = true
                })
                .ToList();

            if (clonedFields.Count > 0)
            {
                await unitOfWork.GetWriteRepository<ServiceDefinitionField>().AddRangeAsync(clonedFields);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            var fieldMap = templateFields.Zip(clonedFields, (oldField, newField) => new { oldField.Id, NewId = newField.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateOptions = templateFields
                .SelectMany(x => x.Options.Where(option => !option.IsDeleted))
                .OrderBy(x => x.ServiceDefinitionFieldId)
                .ThenBy(x => x.DisplayOrder)
                .ToList();

            var clonedOptions = templateOptions
                .Where(x => fieldMap.ContainsKey(x.ServiceDefinitionFieldId))
                .Select(x => new ServiceDefinitionFieldOption
                {
                    ServiceDefinitionFieldId = fieldMap[x.ServiceDefinitionFieldId],
                    Value = x.Value,
                    Label = x.Label,
                    DisplayOrder = x.DisplayOrder,
                    IsActive = true
                })
                .ToList();

            if (clonedOptions.Count > 0)
            {
                await unitOfWork.GetWriteRepository<ServiceDefinitionFieldOption>().AddRangeAsync(clonedOptions);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            var optionMap = templateOptions.Zip(clonedOptions, (oldOption, newOption) => new { oldOption.Id, NewId = newOption.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            await CloneServiceTranslationsAsync(categoryMap, definitionMap, fieldMap, optionMap, cancellationToken);
            await CloneHotelServicePoliciesAsync(hotelId, definitionMap, cancellationToken);
        }

        private async Task CloneServiceTranslationsAsync(
            IReadOnlyDictionary<int, int> categoryMap,
            IReadOnlyDictionary<int, int> definitionMap,
            IReadOnlyDictionary<int, int> fieldMap,
            IReadOnlyDictionary<int, int> optionMap,
            CancellationToken cancellationToken)
        {
            var templateRecordIds = categoryMap.Keys
                .Concat(definitionMap.Keys)
                .Concat(fieldMap.Keys)
                .Concat(optionMap.Keys)
                .Distinct()
                .ToList();

            if (templateRecordIds.Count == 0)
            {
                return;
            }

            var translations = await unitOfWork.GetReadRepository<Translation>()
                .GetAllAsync(x =>
                    !x.IsDeleted &&
                    templateRecordIds.Contains(x.RecordId) &&
                    (x.TableName == nameof(ServiceCategory) ||
                     x.TableName == nameof(ServiceDefinition) ||
                     x.TableName == nameof(ServiceDefinitionField) ||
                     x.TableName == nameof(ServiceDefinitionFieldOption)));

            var clonedTranslations = translations
                .Select(x => TryMapTranslation(x, categoryMap, definitionMap, fieldMap, optionMap))
                .Where(x => x is not null)
                .Select(x => x!)
                .ToList();

            if (clonedTranslations.Count > 0)
            {
                await unitOfWork.GetWriteRepository<Translation>().AddRangeAsync(clonedTranslations);
                await unitOfWork.SaveAsync(cancellationToken);
            }
        }

        private static Translation? TryMapTranslation(
            Translation translation,
            IReadOnlyDictionary<int, int> categoryMap,
            IReadOnlyDictionary<int, int> definitionMap,
            IReadOnlyDictionary<int, int> fieldMap,
            IReadOnlyDictionary<int, int> optionMap)
        {
            var newRecordId = translation.TableName switch
            {
                nameof(ServiceCategory) when categoryMap.TryGetValue(translation.RecordId, out var id) => id,
                nameof(ServiceDefinition) when definitionMap.TryGetValue(translation.RecordId, out var id) => id,
                nameof(ServiceDefinitionField) when fieldMap.TryGetValue(translation.RecordId, out var id) => id,
                nameof(ServiceDefinitionFieldOption) when optionMap.TryGetValue(translation.RecordId, out var id) => id,
                _ => (int?)null
            };

            if (!newRecordId.HasValue)
            {
                return null;
            }

            return new Translation
            {
                TableName = translation.TableName,
                RecordId = newRecordId.Value,
                FieldName = translation.FieldName,
                TranslationValue = translation.TranslationValue,
                LanguageCode = translation.LanguageCode,
                IsActive = true
            };
        }

        private async Task CloneHotelServicePoliciesAsync(
            int hotelId,
            IReadOnlyDictionary<int, int> definitionMap,
            CancellationToken cancellationToken)
        {
            var templatePolicies = await unitOfWork.GetReadRepository<HotelServicePolicy>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedPolicies = templatePolicies.Select(x => new HotelServicePolicy
            {
                HotelId = hotelId,
                ServiceType = x.ServiceType,
                ServiceItemId = x.ServiceItemId,
                ServiceDefinitionId = x.ServiceDefinitionId.HasValue && definitionMap.ContainsKey(x.ServiceDefinitionId.Value)
                    ? definitionMap[x.ServiceDefinitionId.Value]
                    : null,
                AccommodationConceptType = x.AccommodationConceptType,
                IsVisible = true,
                IsIncludedInPackage = x.IsIncludedInPackage,
                IsChargeable = x.IsChargeable,
                AllowRoomCharge = x.AllowRoomCharge,
                AllowOnlinePayment = x.AllowOnlinePayment,
                AllowOnSitePayment = x.AllowOnSitePayment,
                PriceOverride = x.PriceOverride,
                CurrencyCode = x.CurrencyCode,
                Description = x.Description,
                IsActive = true
            }).ToList();

            if (clonedPolicies.Count > 0)
            {
                await unitOfWork.GetWriteRepository<HotelServicePolicy>().AddRangeAsync(clonedPolicies);
                await unitOfWork.SaveAsync(cancellationToken);
            }
        }

        private async Task CloneAnnouncementTemplatesAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<Announcement>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new Announcement
            {
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                Type = x.Type,
                StartAt = x.StartAt,
                EndAt = x.EndAt,
                Location = x.Location,
                IsPinned = x.IsPinned,
                IsVisibleToGuest = x.IsVisibleToGuest,
                AudienceType = x.AudienceType,
                IsActive = x.IsActive
            }).ToList();

            if (clonedData.Count > 0)
            {
                await unitOfWork.GetWriteRepository<Announcement>().AddRangeAsync(clonedData);
                await unitOfWork.SaveAsync(cancellationToken);
            }
        }
    }
}

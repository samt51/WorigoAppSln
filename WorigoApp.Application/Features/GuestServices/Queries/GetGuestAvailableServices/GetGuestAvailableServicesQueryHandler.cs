using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestServices.Dtos;
using WorigoApp.Application.Helpers.ChatFlow;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices
{
    public class GetGuestAvailableServicesQueryHandler : BaseHandler, IRequestHandler<GetGuestAvailableServicesQueryRequest, ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>>
    {
        public GetGuestAvailableServicesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>> Handle(GetGuestAvailableServicesQueryRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(x => x.Id == request.GuestStayId && x.IsActive && !x.IsDeleted);

            var policies = await unitOfWork.GetReadRepository<HotelServicePolicy>()
                .GetAllAsync(x =>
                    x.HotelId == guestStay.HotelId &&
                    x.AccommodationConceptType == guestStay.AccommodationConceptType &&
                    x.IsActive &&
                    !x.IsDeleted);

            var translations = await unitOfWork.GetReadRepository<Translation>()
                .GetAllAsync(x =>
                    x.LanguageCode == guestStay.GuestLanguageCode &&
                    x.IsActive &&
                    !x.IsDeleted);

            var items = new List<GetGuestAvailableServicesQueryResponse>();
            var definitionItems = await BuildDefinitionItemsAsync(guestStay, policies, translations);
            items.AddRange(definitionItems);

            var foods = await unitOfWork.GetReadRepository<Food>()
                .GetAllAsync(
                    x => x.IsAvailable && !x.IsDeleted,
                    include: query => query.Include(x => x.FoodMenuCategory));

            foreach (var food in foods.Where(x => x.FoodMenuCategory.HotelId == guestStay.HotelId))
            {
                var response = BuildResponse(
                    ServicesEnum.Menu,
                    food.Id,
                    ResolveTranslatedValue(translations, ServicesEnum.Menu.ToString(), food.Id, "Name", food.Name),
                    ResolveTranslatedOptionalValue(translations, ServicesEnum.Menu.ToString(), food.Id, "Description", food.Description),
                    null,
                    food.DiscountPrice ?? food.Price,
                    (food.DiscountPrice ?? food.Price) > 0,
                    false,
                    false,
                    null,
                    0,
                    "TRY",
                    ResolvePolicy(policies, ServicesEnum.Menu, food.Id));

                if (response is not null)
                {
                    items.Add(response);
                }
            }

            return new ResponseDto<IList<GetGuestAvailableServicesQueryResponse>>()
                .Success(items.OrderBy(x => x.ServiceType).ThenBy(x => x.DisplayOrder).ThenBy(x => x.Name).ToList());
        }

        private async Task<IList<GetGuestAvailableServicesQueryResponse>> BuildDefinitionItemsAsync(
            GuestStay guestStay,
            IList<HotelServicePolicy> policies,
            IList<Translation> translations)
        {
            var definitions = await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAllAsync(
                    x => x.HotelId == guestStay.HotelId &&
                         x.IsVisibleToGuest &&
                         x.IsActive &&
                         !x.IsDeleted,
                    include: query => query
                        .Include(x => x.ServiceCategory)
                        .Include(x => x.Fields)
                            .ThenInclude(x => x.Options));

            var result = new List<GetGuestAvailableServicesQueryResponse>();

            foreach (var definition in definitions)
            {
                var response = BuildResponse(
                    definition.ServiceType,
                    definition.Id,
                    ResolveTranslatedValue(translations, nameof(ServiceDefinition), definition.Id, "Name", definition.Name),
                    ResolveTranslatedOptionalValue(translations, nameof(ServiceDefinition), definition.Id, "Description", definition.Description),
                    definition.ImageUrl,
                    definition.Price,
                    definition.IsChargeable,
                    definition.SupportsFreeText,
                    definition.RequiresAppointment,
                    definition.EstimatedDurationMinutes,
                    definition.DisplayOrder,
                    definition.CurrencyCode,
                    ResolvePolicy(policies, definition),
                    definition.Id,
                    definition.ServiceCategoryId,
                    ResolveTranslatedValue(translations, nameof(ServiceCategory), definition.ServiceCategoryId, "Name", definition.ServiceCategory.Name),
                    ResolveTranslatedOptionalValue(translations, nameof(ServiceDefinition), definition.Id, "OpeningMessage", definition.OpeningMessage),
                    definition.Fields
                        .Where(x => x.IsActive && !x.IsDeleted)
                        .OrderBy(x => x.DisplayOrder)
                        .Select(x => MapField(x, translations))
                        .ToList(),
                    definition.FlowUiType);

                if (response is not null)
                {
                    result.Add(response);
                }
            }

            return result;
        }

        private static GetGuestAvailableServicesQueryResponse? BuildResponse(
            ServicesEnum serviceType,
            int serviceItemId,
            string name,
            string? description,
            string? imageUrl,
            decimal defaultPrice,
            bool defaultIsChargeable,
            bool supportsFreeText,
            bool requiresAppointment,
            int? estimatedDurationMinutes,
            int displayOrder,
            string defaultCurrencyCode,
            HotelServicePolicy? policy,
            int? serviceDefinitionId = null,
            int? serviceCategoryId = null,
            string? serviceCategoryName = null,
            string? openingMessage = null,
            IList<ServiceDefinitionFieldDto>? fields = null,
            ServiceFlowUiTypeEnum? configuredFlowUiType = null)
        {
            if (policy is not null && !policy.IsVisible)
            {
                return null;
            }

            var isIncludedInPackage = policy?.IsIncludedInPackage == true;
            var isChargeable = !isIncludedInPackage && (policy?.IsChargeable ?? defaultIsChargeable);
            var price = isIncludedInPackage ? 0 : policy?.PriceOverride ?? defaultPrice;
            var flowUiType = configuredFlowUiType ?? ChatFlowTemplateFactory.ResolveUiType(serviceType.ToString(), serviceCategoryName);
            var openingOptions = fields?.Any() == true && flowUiType != ServiceFlowUiTypeEnum.Form
                ? fields.Select(x => (x.Label, x.FieldKey))
                : null;
            var openingPayloadJson = fields?.Any() == true
                ? BuildFieldDrivenPayloadJson(flowUiType, serviceType.ToString(), serviceCategoryName, openingMessage, fields, supportsFreeText, requiresAppointment)
                : ChatFlowTemplateFactory.BuildOpeningPayloadJson(
                    flowUiType,
                    serviceType.ToString(),
                    openingOptions,
                    serviceCategoryName,
                    openingMessage);

            return new GetGuestAvailableServicesQueryResponse
            {
                ServiceDefinitionId = serviceDefinitionId,
                ServiceCategoryId = serviceCategoryId,
                ServiceCategoryName = serviceCategoryName,
                ServiceType = serviceType.ToString(),
                ServiceItemId = serviceItemId,
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                IsChargeable = isChargeable,
                IsIncludedInPackage = isIncludedInPackage,
                Price = isChargeable ? price : 0,
                CurrencyCode = policy?.CurrencyCode ?? defaultCurrencyCode,
                AllowRoomCharge = isIncludedInPackage || policy?.AllowRoomCharge != false,
                AllowOnlinePayment = policy?.AllowOnlinePayment ?? false,
                AllowOnSitePayment = isIncludedInPackage || policy?.AllowOnSitePayment != false,
                SupportsFreeText = supportsFreeText,
                RequiresAppointment = requiresAppointment,
                EstimatedDurationMinutes = estimatedDurationMinutes,
                DisplayOrder = displayOrder,
                FlowUiType = flowUiType,
                OpeningMessageType = ChatFlowTemplateFactory.ResolveOpeningMessageType(flowUiType),
                OpeningMessage = string.IsNullOrWhiteSpace(openingMessage)
                    ? ChatFlowTemplateFactory.ResolveOpeningMessage(flowUiType, serviceType.ToString(), serviceCategoryName)
                    : openingMessage,
                OpeningPayloadJson = openingPayloadJson,
                Fields = fields ?? new List<ServiceDefinitionFieldDto>()
            };
        }

        private static string BuildFieldDrivenPayloadJson(
            ServiceFlowUiTypeEnum flowUiType,
            string serviceType,
            string? categoryName,
            string? openingMessage,
            IList<ServiceDefinitionFieldDto> fields,
            bool supportsFreeText,
            bool requiresAppointment)
        {
            var title = string.IsNullOrWhiteSpace(openingMessage)
                ? ChatFlowTemplateFactory.ResolveOpeningMessage(flowUiType, serviceType, categoryName)
                : openingMessage;

            var payload = new
            {
                uiType = flowUiType.ToString(),
                title,
                supportsFreeText,
                requiresAppointment,
                fields = fields
                    .OrderBy(x => x.DisplayOrder)
                    .Select(x => new
                    {
                        id = x.Id,
                        key = x.FieldKey,
                        label = x.Label,
                        placeholder = x.Placeholder,
                        type = x.FieldType.ToString(),
                        isRequired = x.IsRequired,
                        displayOrder = x.DisplayOrder,
                        options = x.Options.Any()
                            ? x.Options.OrderBy(option => option.DisplayOrder).Select(option => new
                            {
                                id = option.Id,
                                value = option.Value,
                                label = option.Label
                            })
                            : ParseOptions(x.OptionsJson),
                        validationRegex = x.ValidationRegex,
                        defaultValue = x.DefaultValue
                    })
            };

            return JsonSerializer.Serialize(payload);
        }

        private static object? ParseOptions(string? optionsJson)
        {
            if (string.IsNullOrWhiteSpace(optionsJson))
            {
                return null;
            }

            try
            {
                return JsonSerializer.Deserialize<JsonElement>(optionsJson);
            }
            catch (JsonException)
            {
                return optionsJson;
            }
        }

        private static HotelServicePolicy? ResolvePolicy(IList<HotelServicePolicy> policies, ServicesEnum serviceType, int serviceItemId)
        {
            return policies
                .OrderByDescending(x => x.ServiceItemId.HasValue)
                .FirstOrDefault(x => x.ServiceType == serviceType && (x.ServiceItemId == serviceItemId || x.ServiceItemId is null));
        }

        private static HotelServicePolicy? ResolvePolicy(IList<HotelServicePolicy> policies, ServiceDefinition definition)
        {
            return policies
                .OrderByDescending(x => x.ServiceDefinitionId.HasValue)
                .ThenByDescending(x => x.ServiceItemId.HasValue)
                .FirstOrDefault(x =>
                    (x.ServiceDefinitionId == definition.Id) ||
                    (x.ServiceDefinitionId is null &&
                     x.ServiceType == definition.ServiceType &&
                     (x.ServiceItemId == definition.Id || x.ServiceItemId is null)));
        }

        private static ServiceDefinitionFieldDto MapField(ServiceDefinitionField field, IList<Translation> translations)
        {
            return new ServiceDefinitionFieldDto
            {
                Id = field.Id,
                FieldKey = field.FieldKey,
                Label = ResolveTranslatedValue(translations, nameof(ServiceDefinitionField), field.Id, "Label", field.Label),
                Placeholder = ResolveTranslatedOptionalValue(translations, nameof(ServiceDefinitionField), field.Id, "Placeholder", field.Placeholder),
                FieldType = field.FieldType,
                IsRequired = field.IsRequired,
                DisplayOrder = field.DisplayOrder,
                OptionsJson = field.OptionsJson,
                Options = field.Options
                    .Where(x => x.IsActive && !x.IsDeleted)
                    .OrderBy(x => x.DisplayOrder)
                    .Select(x => new ServiceDefinitionFieldOptionDto
                    {
                        Id = x.Id,
                        Value = x.Value,
                        Label = ResolveTranslatedValue(translations, nameof(ServiceDefinitionFieldOption), x.Id, "Label", x.Label),
                        DisplayOrder = x.DisplayOrder
                    })
                    .ToList(),
                ValidationRegex = field.ValidationRegex,
                DefaultValue = field.DefaultValue
            };
        }

        private static string ResolveTranslatedValue(
            IList<Translation> translations,
            string tableName,
            int recordId,
            string fieldName,
            string fallbackValue)
        {
            return translations.FirstOrDefault(x =>
                       x.TableName == tableName &&
                       x.RecordId == recordId &&
                       x.FieldName == fieldName)
                   ?.TranslationValue
                   ?? fallbackValue;
        }

        private static string? ResolveTranslatedOptionalValue(
            IList<Translation> translations,
            string tableName,
            int recordId,
            string fieldName,
            string? fallbackValue)
        {
            if (string.IsNullOrWhiteSpace(fallbackValue))
            {
                return fallbackValue;
            }

            return translations.FirstOrDefault(x =>
                       x.TableName == tableName &&
                       x.RecordId == recordId &&
                       x.FieldName == fieldName)
                   ?.TranslationValue
                   ?? fallbackValue;
        }
    }
}

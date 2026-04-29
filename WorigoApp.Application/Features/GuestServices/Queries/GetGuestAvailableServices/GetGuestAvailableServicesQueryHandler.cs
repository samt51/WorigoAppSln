using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestServices.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;
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
            var hasServiceDefinitions = definitionItems.Any();
            items.AddRange(definitionItems);

            if (!hasServiceDefinitions)
            {
                items.AddRange(await BuildItemsAsync<TechnicalNeed>(
                    ServicesEnum.TechnicalNeed,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => false,
                    x => x.SupportsFreeText,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => x.DisplayOrder,
                    x => 0,
                    x => "TRY"));

                items.AddRange(await BuildItemsAsync<HouseKeeping>(
                    ServicesEnum.HouseKeeping,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => false,
                    x => x.SupportsFreeText,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => x.DisplayOrder,
                    x => 0,
                    x => "TRY"));

                items.AddRange(await BuildItemsAsync<BellBoy>(
                    ServicesEnum.BellBoy,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => false,
                    x => false,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => 0,
                    x => 0,
                    x => "TRY"));

                items.AddRange(await BuildItemsAsync<DryCleaner>(
                    ServicesEnum.DryCleaner,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => x.IsChargeable,
                    x => false,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => x.DisplayOrder,
                    x => x.Price ?? 0,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<SpaMassage>(
                    ServicesEnum.SpaMessage,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    _ => null,
                    x => x.IsChargeable,
                    x => false,
                    x => x.RequiresAppointment,
                    x => x.EstimatedDurationMinutes,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<TravelOrTransportation>(
                    ServicesEnum.TravelOrTransportation,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.TransportationType,
                    x => x.Description,
                    _ => null,
                    x => x.IsChargeable,
                    x => false,
                    x => true,
                    _ => null,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<MinibarService>(
                    ServicesEnum.Minibar,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => x.IsChargeable,
                    x => false,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => x.DisplayOrder,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<WakeUpCallService>(
                    ServicesEnum.WakeUpCall,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    _ => null,
                    x => x.IsChargeable,
                    x => false,
                    x => x.RequiresAppointment,
                    _ => null,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<ValetParkingService>(
                    ServicesEnum.ValetParking,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => x.IsChargeable,
                    x => false,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<StayExtensionService>(
                    ServicesEnum.StayExtension,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    _ => null,
                    x => x.IsChargeable,
                    x => false,
                    x => x.RequiresAppointment,
                    _ => null,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<AmenityRequestService>(
                    ServicesEnum.AmenityRequest,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    x => x.ImageUrl,
                    x => x.IsChargeable,
                    x => x.SupportsFreeText,
                    x => false,
                    x => x.EstimatedDurationMinutes,
                    x => x.DisplayOrder,
                    x => x.Price,
                    x => x.CurrencyCode));

                items.AddRange(await BuildItemsAsync<MedicalAssistanceService>(
                    ServicesEnum.MedicalAssistance,
                    policies,
                    translations,
                    x => x.HotelId == guestStay.HotelId && x.IsVisibleToGuest,
                    x => x.Id,
                    x => x.Name,
                    x => x.Description,
                    _ => null,
                    x => x.IsChargeable,
                    x => x.SupportsFreeText,
                    x => x.RequiresAppointment,
                    _ => null,
                    _ => 0,
                    x => x.Price,
                    x => x.CurrencyCode));
            }

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

        private async Task<IList<GetGuestAvailableServicesQueryResponse>> BuildItemsAsync<TEntity>(
            ServicesEnum serviceType,
            IList<HotelServicePolicy> policies,
            IList<Translation> translations,
            System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate,
            Func<TEntity, int> idSelector,
            Func<TEntity, string> nameSelector,
            Func<TEntity, string?> descriptionSelector,
            Func<TEntity, string?> imageSelector,
            Func<TEntity, bool> chargeableSelector,
            Func<TEntity, bool> supportsFreeTextSelector,
            Func<TEntity, bool> requiresAppointmentSelector,
            Func<TEntity, int?> estimatedDurationSelector,
            Func<TEntity, int> displayOrderSelector,
            Func<TEntity, decimal> priceSelector,
            Func<TEntity, string> currencySelector)
            where TEntity : class, IEntityBase, new()
        {
            var entities = await unitOfWork.GetReadRepository<TEntity>().GetAllAsync(predicate);
            var result = new List<GetGuestAvailableServicesQueryResponse>();

            foreach (var entity in entities)
            {
                var response = BuildResponse(
                    serviceType,
                    idSelector(entity),
                    ResolveTranslatedValue(translations, serviceType.ToString(), idSelector(entity), "Name", nameSelector(entity)),
                    ResolveTranslatedOptionalValue(translations, serviceType.ToString(), idSelector(entity), "Description", descriptionSelector(entity)),
                    imageSelector(entity),
                    priceSelector(entity),
                    chargeableSelector(entity),
                    supportsFreeTextSelector(entity),
                    requiresAppointmentSelector(entity),
                    estimatedDurationSelector(entity),
                    displayOrderSelector(entity),
                    currencySelector(entity),
                    ResolvePolicy(policies, serviceType, idSelector(entity)));

                if (response is not null)
                {
                    result.Add(response);
                }
            }

            return result;
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
                        .Include(x => x.Fields));

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
                    definition.Fields
                        .Where(x => x.IsActive && !x.IsDeleted)
                        .OrderBy(x => x.DisplayOrder)
                        .Select(x => MapField(x, translations))
                        .ToList());

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
            IList<ServiceDefinitionFieldDto>? fields = null)
        {
            if (policy is not null && !policy.IsVisible)
            {
                return null;
            }

            var isIncludedInPackage = policy?.IsIncludedInPackage == true;
            var isChargeable = !isIncludedInPackage && (policy?.IsChargeable ?? defaultIsChargeable);
            var price = isIncludedInPackage ? 0 : policy?.PriceOverride ?? defaultPrice;

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
                Fields = fields ?? new List<ServiceDefinitionFieldDto>()
            };
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

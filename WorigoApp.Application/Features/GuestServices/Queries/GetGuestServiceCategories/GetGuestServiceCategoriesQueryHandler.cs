using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices;
using WorigoApp.Application.Helpers.ChatFlow;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategories
{
    public class GetGuestServiceCategoriesQueryHandler : BaseHandler, IRequestHandler<GetGuestServiceCategoriesQueryRequest, ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>>
    {
        private readonly IMediator _mediator;

        public GetGuestServiceCategoriesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IMediator mediator) : base(mapper, unitOfWork)
        {
            _mediator = mediator;
        }

        public async Task<ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>> Handle(GetGuestServiceCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResponse = await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = request.GuestStayId
            }, cancellationToken);

            if (!serviceResponse.IsSuccess || serviceResponse.Data is null)
            {
                return new ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>()
                    .Fail(serviceResponse.Errors ?? new List<string> { "Servis kategorileri listelenemedi." }, serviceResponse.StatusCode);
            }

            var categories = serviceResponse.Data
                .GroupBy(x => new
                {
                    x.ServiceCategoryId,
                    DisplayName = x.ServiceCategoryName ?? x.ServiceType,
                    x.ServiceType
                })
                .Select(group =>
                {
                    var flowUiType = ChatFlowTemplateFactory.ResolveUiType(group.Key.ServiceType, group.Key.DisplayName);
                    var openingMessage = group.Count() == 1
                        ? group.Select(x => x.OpeningMessage).FirstOrDefault()
                        : ChatFlowTemplateFactory.ResolveOpeningMessage(flowUiType, group.Key.ServiceType, group.Key.DisplayName);

                    return new GetGuestServiceCategoriesQueryResponse
                    {
                        ServiceCategoryId = group.Key.ServiceCategoryId,
                        ServiceType = group.Key.ServiceType,
                        DisplayName = group.Key.DisplayName,
                        ItemCount = group.Count(),
                        ContainsChargeableItems = group.Any(x => x.IsChargeable),
                        ContainsIncludedItems = group.Any(x => x.IsIncludedInPackage),
                        MinimumPrice = group.Where(x => x.IsChargeable && x.Price > 0).Select(x => (decimal?)x.Price).Min(),
                        CurrencyCode = group.Select(x => x.CurrencyCode).FirstOrDefault() ?? "TRY",
                        PreviewImageUrl = group.Select(x => x.ImageUrl).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)),
                        FlowUiType = flowUiType,
                        OpeningMessageType = ChatFlowTemplateFactory.ResolveOpeningMessageType(flowUiType),
                        OpeningMessage = openingMessage ?? string.Empty,
                        OpeningPayloadJson = ChatFlowTemplateFactory.BuildOpeningPayloadJson(
                            flowUiType,
                            group.Key.ServiceType,
                            group.Select(x => (x.Name, x.ServiceDefinitionId?.ToString() ?? x.ServiceItemId.ToString())),
                            group.Key.DisplayName,
                            openingMessage)
                    };
                })
                .OrderBy(x => x.DisplayName)
                .ToList();

            return new ResponseDto<IList<GetGuestServiceCategoriesQueryResponse>>().Success(categories);
        }
    }
}

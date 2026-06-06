using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestServices.Queries.GetGuestAvailableServices;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Features.GuestServices.Queries.GetGuestServiceCategoryItems
{
    public class GetGuestServiceCategoryItemsQueryHandler : BaseHandler, IRequestHandler<GetGuestServiceCategoryItemsQueryRequest, ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>>
    {
        private readonly IMediator _mediator;

        public GetGuestServiceCategoryItemsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, IMediator mediator) : base(mapper, unitOfWork)
        {
            _mediator = mediator;
        }

        public async Task<ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>> Handle(GetGuestServiceCategoryItemsQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceResponse = await _mediator.Send(new GetGuestAvailableServicesQueryRequest
            {
                GuestStayId = request.GuestStayId
            }, cancellationToken);

            if (!serviceResponse.IsSuccess || serviceResponse.Data is null)
            {
                return new ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>()
                    .Fail(serviceResponse.Errors ?? new List<string> { "Servis detayları listelenemedi." }, serviceResponse.StatusCode);
            }

            var items = serviceResponse.Data
                .Where(x => x.ServiceType == request.ServiceType.ToString())
                .OrderBy(x => x.DisplayOrder)
                .ThenBy(x => x.Name)
                .Select(x =>
                {
                    return new GetGuestServiceCategoryItemsQueryResponse
                    {
                        ServiceDefinitionId = x.ServiceDefinitionId,
                        ServiceCategoryId = x.ServiceCategoryId,
                        ServiceCategoryName = x.ServiceCategoryName,
                        ServiceType = x.ServiceType,
                        ServiceItemId = x.ServiceItemId,
                        Name = x.Name,
                        Description = x.Description,
                        ImageUrl = x.ImageUrl,
                        IsChargeable = x.IsChargeable,
                        IsIncludedInPackage = x.IsIncludedInPackage,
                        Price = x.Price,
                        CurrencyCode = x.CurrencyCode,
                        AllowRoomCharge = x.AllowRoomCharge,
                        AllowOnlinePayment = x.AllowOnlinePayment,
                        AllowOnSitePayment = x.AllowOnSitePayment,
                        SupportsFreeText = x.SupportsFreeText,
                        RequiresAppointment = x.RequiresAppointment,
                        EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                        DisplayOrder = x.DisplayOrder,
                        FlowUiType = x.FlowUiType,
                        OpeningMessageType = x.OpeningMessageType,
                        OpeningMessage = x.OpeningMessage,
                        OpeningPayloadJson = x.OpeningPayloadJson,
                        Fields = x.Fields
                    };
                })
                .ToList();

            return new ResponseDto<IList<GetGuestServiceCategoryItemsQueryResponse>>().Success(items);
        }
    }
}

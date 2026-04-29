using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.HotelServicePolicies.Queries.GetHotelServicePolicies
{
    public class GetHotelServicePoliciesQueryHandler : BaseHandler, IRequestHandler<GetHotelServicePoliciesQueryRequest, ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>>
    {
        public GetHotelServicePoliciesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>> Handle(GetHotelServicePoliciesQueryRequest request, CancellationToken cancellationToken)
        {
            var policies = await unitOfWork.GetReadRepository<HotelServicePolicy>()
                .GetAllAsync(x =>
                    x.HotelId == request.HotelId &&
                    x.IsActive &&
                    !x.IsDeleted &&
                    (!request.AccommodationConceptType.HasValue || x.AccommodationConceptType == request.AccommodationConceptType.Value));

            var response = policies
                .OrderBy(x => x.ServiceType)
                .ThenBy(x => x.ServiceItemId)
                .Select(x => new GetHotelServicePoliciesQueryResponse
                {
                    Id = x.Id,
                    HotelId = x.HotelId,
                    ServiceType = x.ServiceType.ToString(),
                    ServiceItemId = x.ServiceItemId,
                    AccommodationConceptType = x.AccommodationConceptType.ToString(),
                    IsVisible = x.IsVisible,
                    IsIncludedInPackage = x.IsIncludedInPackage,
                    IsChargeable = x.IsChargeable,
                    AllowRoomCharge = x.AllowRoomCharge,
                    AllowOnlinePayment = x.AllowOnlinePayment,
                    AllowOnSitePayment = x.AllowOnSitePayment,
                    PriceOverride = x.PriceOverride,
                    CurrencyCode = x.CurrencyCode,
                    Description = x.Description
                })
                .ToList();

            return new ResponseDto<IList<GetHotelServicePoliciesQueryResponse>>().Success(response);
        }
    }
}

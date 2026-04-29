using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy
{
    public class UpsertHotelServicePolicyCommandHandler : BaseHandler, IRequestHandler<UpsertHotelServicePolicyCommandRequest, ResponseDto<UpsertHotelServicePolicyCommandResponse>>
    {
        public UpsertHotelServicePolicyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpsertHotelServicePolicyCommandResponse>> Handle(UpsertHotelServicePolicyCommandRequest request, CancellationToken cancellationToken)
        {
            var hotel = await unitOfWork.GetReadRepository<Hotel>()
                .FindAsync(x => x.Id == request.HotelId && x.IsActive && !x.IsDeleted);

            if (hotel is null)
            {
                return new ResponseDto<UpsertHotelServicePolicyCommandResponse>()
                    .Fail(new List<string> { "Otel bulunamadi." }, 404);
            }

            var existingPolicy = await unitOfWork.GetReadRepository<HotelServicePolicy>()
                .FindAsync(x =>
                    x.HotelId == request.HotelId &&
                    x.ServiceType == request.ServiceType &&
                    x.ServiceItemId == request.ServiceItemId &&
                    x.AccommodationConceptType == request.AccommodationConceptType &&
                    !x.IsDeleted,
                    enableTracking: true);

            string message;

            if (existingPolicy is null)
            {
                existingPolicy = new HotelServicePolicy
                {
                    HotelId = request.HotelId,
                    ServiceType = request.ServiceType,
                    ServiceItemId = request.ServiceItemId,
                    AccommodationConceptType = request.AccommodationConceptType
                };

                await unitOfWork.GetWriteRepository<HotelServicePolicy>().AddAsync(existingPolicy);
                message = "Servis kuralı oluşturuldu.";
            }
            else
            {
                message = "Servis kuralı güncellendi.";
            }

            existingPolicy.IsVisible = request.IsVisible;
            existingPolicy.IsIncludedInPackage = request.IsIncludedInPackage;
            existingPolicy.IsChargeable = request.IsChargeable;
            existingPolicy.AllowRoomCharge = request.AllowRoomCharge;
            existingPolicy.AllowOnlinePayment = request.AllowOnlinePayment;
            existingPolicy.AllowOnSitePayment = request.AllowOnSitePayment;
            existingPolicy.PriceOverride = request.PriceOverride;
            existingPolicy.CurrencyCode = request.CurrencyCode;
            existingPolicy.Description = request.Description;
            existingPolicy.IsActive = true;
            existingPolicy.ModifyDate = DateTime.UtcNow;

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpsertHotelServicePolicyCommandResponse>().Success(new UpsertHotelServicePolicyCommandResponse
            {
                Id = existingPolicy.Id,
                HotelId = existingPolicy.HotelId,
                Message = message
            });
        }
    }
}

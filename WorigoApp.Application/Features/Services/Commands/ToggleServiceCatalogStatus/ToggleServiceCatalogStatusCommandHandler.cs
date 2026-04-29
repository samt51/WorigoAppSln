using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
    public class ToggleServiceCatalogStatusCommandHandler : BaseHandler, IRequestHandler<ToggleServiceCatalogStatusCommandRequest, ResponseDto<ToggleServiceCatalogStatusCommandResponse>>
    {
        public ToggleServiceCatalogStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<ToggleServiceCatalogStatusCommandResponse>> Handle(ToggleServiceCatalogStatusCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.OpenTransactionAsync(cancellationToken);

            switch (request.ServiceType)
            {
                case ServicesEnum.TechnicalNeed:
                    await ToggleAsync<TechnicalNeed>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.HouseKeeping:
                    await ToggleAsync<HouseKeeping>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.BellBoy:
                    await ToggleAsync<BellBoy>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.DryCleaner:
                    await ToggleAsync<DryCleaner>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.SpaMessage:
                    await ToggleAsync<SpaMassage>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.Minibar:
                    await ToggleAsync<MinibarService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.WakeUpCall:
                    await ToggleAsync<WakeUpCallService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.ValetParking:
                    await ToggleAsync<ValetParkingService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.StayExtension:
                    await ToggleAsync<StayExtensionService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.AmenityRequest:
                    await ToggleAsync<AmenityRequestService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.MedicalAssistance:
                    await ToggleAsync<MedicalAssistanceService>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                case ServicesEnum.TravelOrTransportation:
                    await ToggleAsync<TravelOrTransportation>(request, cancellationToken, x => x.HotelId == request.HotelId);
                    break;
                default:
                    throw new NotImplementedException("Bu servis tipi icin ac/kapat akisi tanimli degil.");
            }

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<ToggleServiceCatalogStatusCommandResponse>().Success(new ToggleServiceCatalogStatusCommandResponse
            {
                ServiceType = request.ServiceType,
                ServiceCatalogItemId = request.ServiceCatalogItemId,
                IsActive = request.IsActive
            });
        }

        private async Task ToggleAsync<T>(ToggleServiceCatalogStatusCommandRequest request, CancellationToken cancellationToken, Func<T, bool> hotelPredicate)
            where T : EntityBase, new()
        {
            var entity = await unitOfWork.GetReadRepository<T>()
                .GetAsync(x => x.Id == request.ServiceCatalogItemId && !x.IsDeleted, enableTracking: true);

            if (!hotelPredicate(entity))
            {
                throw new Exception("Servis kaydi ilgili otele ait degil.");
            }

            entity.IsActive = request.IsActive;
            await unitOfWork.GetWriteRepository<T>().UpdateAsync(entity);
            await unitOfWork.SaveAsync(cancellationToken);
        }
    }
}

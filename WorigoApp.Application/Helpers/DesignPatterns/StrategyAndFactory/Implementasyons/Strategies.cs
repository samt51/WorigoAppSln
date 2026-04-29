using WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Interfaces;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Implementasyons
{
    public class Strategies
    {
        public class FoodServiceStrategy : IServiceStrategy<Food>
        {
            private readonly IUnitOfWork _unitOfWork;

            public FoodServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Food> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<Food>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class SpaMessageServiceStrategy : IServiceStrategy<SpaMassage>
        {
            private readonly IUnitOfWork _unitOfWork;

            public SpaMessageServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<SpaMassage> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<SpaMassage>().GetAsync(y => y.Id == serviceItemId);
            }
        }

        public class DryCleanerServiceStrategy : IServiceStrategy<DryCleaner>
        {
            private readonly IUnitOfWork _unitOfWork;

            public DryCleanerServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<DryCleaner> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<DryCleaner>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class BellBoyServiceStrategy : IServiceStrategy<BellBoy>
        {
            private readonly IUnitOfWork _unitOfWork;

            public BellBoyServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<BellBoy> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<BellBoy>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class TechnicalNeedServiceStrategy : IServiceStrategy<TechnicalNeed>
        {
            private readonly IUnitOfWork _unitOfWork;

            public TechnicalNeedServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<TechnicalNeed> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<TechnicalNeed>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class HouseKeepingServiceStrategy : IServiceStrategy<HouseKeeping>
        {
            private readonly IUnitOfWork _unitOfWork;

            public HouseKeepingServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<HouseKeeping> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<HouseKeeping>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class MinibarServiceStrategy : IServiceStrategy<MinibarService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public MinibarServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<MinibarService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<MinibarService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class WakeUpCallServiceStrategy : IServiceStrategy<WakeUpCallService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public WakeUpCallServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<WakeUpCallService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<WakeUpCallService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class ValetParkingServiceStrategy : IServiceStrategy<ValetParkingService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public ValetParkingServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<ValetParkingService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<ValetParkingService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class StayExtensionServiceStrategy : IServiceStrategy<StayExtensionService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public StayExtensionServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<StayExtensionService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<StayExtensionService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class AmenityRequestServiceStrategy : IServiceStrategy<AmenityRequestService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public AmenityRequestServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<AmenityRequestService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<AmenityRequestService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class MedicalAssistanceServiceStrategy : IServiceStrategy<MedicalAssistanceService>
        {
            private readonly IUnitOfWork _unitOfWork;

            public MedicalAssistanceServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<MedicalAssistanceService> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<MedicalAssistanceService>().GetAsync(y => y.Id == serviceItemId);
            }
        }
        public class TravelOrTransportationServiceStrategy : IServiceStrategy<TravelOrTransportation>
        {
            private readonly IUnitOfWork _unitOfWork;

            public TravelOrTransportationServiceStrategy(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<TravelOrTransportation> GetServiceItemAsync(int serviceItemId)
            {
                return await _unitOfWork.GetReadRepository<TravelOrTransportation>().GetAsync(y => y.Id == serviceItemId);
            }
        }
    }
}

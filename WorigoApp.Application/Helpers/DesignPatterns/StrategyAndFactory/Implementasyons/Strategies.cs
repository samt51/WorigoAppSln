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
    }
}

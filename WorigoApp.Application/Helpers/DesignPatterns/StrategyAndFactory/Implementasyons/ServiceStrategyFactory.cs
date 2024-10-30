using static WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Implementasyons.Strategies;
using WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Interfaces;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Implementasyons
{
    public class ServiceStrategyFactory
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceStrategyFactory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IServiceStrategy<T> GetServiceStrategy<T>(ServicesEnum servicesEnum)
        {
            return servicesEnum switch
            {
                ServicesEnum.Menu => (IServiceStrategy<T>)new FoodServiceStrategy(_unitOfWork),
                ServicesEnum.SpaMessage => (IServiceStrategy<T>)new SpaMessageServiceStrategy(_unitOfWork),
                ServicesEnum.DryCleaner => (IServiceStrategy<T>)new DryCleanerServiceStrategy(_unitOfWork),
                ServicesEnum.BellBoy => (IServiceStrategy<T>)new BellBoyServiceStrategy(_unitOfWork),
                ServicesEnum.TechnicalNeed => (IServiceStrategy<T>)new TechnicalNeedServiceStrategy(_unitOfWork),
                ServicesEnum.HouseKeeping => (IServiceStrategy<T>)new HouseKeepingServiceStrategy(_unitOfWork),
                _ => throw new NotImplementedException("Service type not implemented"),
            };
        }
    }

}

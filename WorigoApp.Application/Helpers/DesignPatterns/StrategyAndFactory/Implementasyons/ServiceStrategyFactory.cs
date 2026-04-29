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
                ServicesEnum.Minibar => (IServiceStrategy<T>)new MinibarServiceStrategy(_unitOfWork),
                ServicesEnum.WakeUpCall => (IServiceStrategy<T>)new WakeUpCallServiceStrategy(_unitOfWork),
                ServicesEnum.ValetParking => (IServiceStrategy<T>)new ValetParkingServiceStrategy(_unitOfWork),
                ServicesEnum.StayExtension => (IServiceStrategy<T>)new StayExtensionServiceStrategy(_unitOfWork),
                ServicesEnum.AmenityRequest => (IServiceStrategy<T>)new AmenityRequestServiceStrategy(_unitOfWork),
                ServicesEnum.MedicalAssistance => (IServiceStrategy<T>)new MedicalAssistanceServiceStrategy(_unitOfWork),
                ServicesEnum.TravelOrTransportation => (IServiceStrategy<T>)new TravelOrTransportationServiceStrategy(_unitOfWork),
                _ => throw new NotImplementedException("Service type not implemented"),
            };
        }
    }

}

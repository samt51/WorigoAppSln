using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Implementasyons;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, Response<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateOrderCommandResponse>> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<RoomBasedTransaction>().GetAsync(x => x.IsActive && x.Id == request.RoomBasedTransactionId);

            var totalPrice = request.CreateOrderItems.Sum(x => x.Price);

            var serviceStrategyFactory = new ServiceStrategyFactory(unitOfWork);

            foreach (var item in request.CreateOrderItems)
            {
                switch (item.ServicesEnumId)
                {
                    case ServicesEnum.Menu:
                        var foodServiceStrategy = serviceStrategyFactory.GetServiceStrategy<Food>(item.ServicesEnumId);
                        var foodData = await foodServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // Food veri türüyle işlem yapabilirsiniz
                        break;

                    case ServicesEnum.SpaMessage:
                        var spaServiceStrategy = serviceStrategyFactory.GetServiceStrategy<SpaMassage>(item.ServicesEnumId);
                        var spaData = await spaServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // SpaMassage veri türüyle işlem yapabilirsiniz
                        break;

                    case ServicesEnum.DryCleaner:
                        var dryCleanerServiceStrategy = serviceStrategyFactory.GetServiceStrategy<DryCleaner>(item.ServicesEnumId);
                        var dryCleanerData = await dryCleanerServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // DryCleaner veri türüyle işlem yapabilirsiniz
                        break;

                    case ServicesEnum.BellBoy:
                        var bellBoyServiceStrategy = serviceStrategyFactory.GetServiceStrategy<BellBoy>(item.ServicesEnumId);
                        var bellBoyData = await bellBoyServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // BellBoy veri türüyle işlem yapabilirsiniz
                        break;

                    case ServicesEnum.TechnicalNeed:
                        var technicalServiceStrategy = serviceStrategyFactory.GetServiceStrategy<TechnicalNeed>(item.ServicesEnumId);
                        var technicalData = await technicalServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // TechnicalNeed veri türüyle işlem yapabilirsiniz
                        break;

                    case ServicesEnum.HouseKeeping:
                        var houseKeepingServiceStrategy = serviceStrategyFactory.GetServiceStrategy<HouseKeeping>(item.ServicesEnumId);
                        var houseKeepingData = await houseKeepingServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                        // HouseKeeping veri türüyle işlem yapabilirsiniz
                        break;

                    default:
                        throw new NotImplementedException("Unknown service type.");
                }
            }
            return new Response<CreateOrderCommandResponse>().Success();
        }
    }
}
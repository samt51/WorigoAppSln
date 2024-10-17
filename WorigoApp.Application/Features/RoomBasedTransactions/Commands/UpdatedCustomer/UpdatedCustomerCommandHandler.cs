using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomBasedTransactions.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomBasedTransactions.Commands.UpdatedCustomer
{
    public class UpdatedCustomerCommandHandler : BaseHandler, IRequestHandler<UpdatedCustomerCommandRequest, Response<UpdatedCustomerCommandResponse>>
    {
        private readonly RoomBasedTransactionRule _roomBasedTransactionRule;
        public UpdatedCustomerCommandHandler(RoomBasedTransactionRule roomBasedTransactionRule, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _roomBasedTransactionRule = roomBasedTransactionRule;
        }

        public async Task<Response<UpdatedCustomerCommandResponse>> Handle(UpdatedCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var roomBasedTransaction = await unitOfWork.GetReadRepository<RoomBasedTransaction>().GetAsync(y => y.Id == request.Id && y.IsActive);

            await _roomBasedTransactionRule.ControllCheckInAndCheckOutDates(request);

            var mapEntity = mapper.Map<RoomBasedTransaction, UpdatedCustomerCommandRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<RoomBasedTransaction>().UpdateAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdatedCustomerCommandResponse>().Success();

        }
    }
}

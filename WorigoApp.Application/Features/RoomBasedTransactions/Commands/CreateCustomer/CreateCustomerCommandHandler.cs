using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomBasedTransactions.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomBasedTransactions.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : BaseHandler, IRequestHandler<CreateCustomerCommandRequest, Response<CreateCustomerCommandResponse>>
    {
        public CreateCustomerCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateCustomerCommandResponse>> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var room = await unitOfWork.GetReadRepository<Room>().GetAsync(y => y.HotelId == request.HotelId && y.Id == request.RoomId && !y.IsDeleted && !y.IsFull);

            var customerMap = mapper.Map<Customer, CustomerRequestDto>(request.CustomerRequestDto);

            unitOfWork.OpenTransaction();

            var customer = await unitOfWork.GetWriteRepository<Customer>().AddAsync(customerMap);

            await unitOfWork.SaveAsync();

            var roomBasedTransactionMap = mapper.Map<RoomBasedTransaction, CreateCustomerCommandRequest>(request);

            roomBasedTransactionMap.CustomerId = customer.Id;

            roomBasedTransactionMap.VerificationCode = Guid.NewGuid().ToString();

            await unitOfWork.GetWriteRepository<RoomBasedTransaction>().AddAsync(roomBasedTransactionMap);

            await unitOfWork.SaveAsync();

            room.IsFull = true;

            await unitOfWork.GetWriteRepository<Room>().UpdateAsync(room);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateCustomerCommandResponse>().Success();

        }
    }
}

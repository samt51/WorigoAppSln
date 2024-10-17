using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByRoomBasedTransactionId
{
    public class CreateCustomerByRoomBasedTransactionIdHandler : BaseHandler, IRequestHandler<CreateCustomerByRoomBasedTransactionIdRequest, Response<CreateCustomerByRoomBasedTransactionIdResponse>>
    {
        public CreateCustomerByRoomBasedTransactionIdHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateCustomerByRoomBasedTransactionIdResponse>> Handle(CreateCustomerByRoomBasedTransactionIdRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<RoomBasedTransaction>().GetAsync(y => y.IsActive && y.Id == request.RoomBasedTransactionId);

            var mapEntity = mapper.Map<Customer, CreateCustomerByRoomBasedTransactionIdRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<Customer>().AddAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateCustomerByRoomBasedTransactionIdResponse>();
        }
    }
}

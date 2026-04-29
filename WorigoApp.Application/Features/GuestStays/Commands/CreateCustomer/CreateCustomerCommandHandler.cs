using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestStays.Dtos;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.GuestStays.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : BaseHandler, IRequestHandler<CreateCustomerCommandRequest, ResponseDto<CreateCustomerCommandResponse>>
    {
        public CreateCustomerCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateCustomerCommandResponse>> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var room = await unitOfWork.GetReadRepository<Room>().GetAsync(y => y.HotelId == request.HotelId && y.Id == request.RoomId && !y.IsDeleted && !y.IsFull);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var guestStayMap = mapper.Map<GuestStay, CreateCustomerCommandRequest>(request);

            guestStayMap.VerificationCode = Guid.NewGuid().ToString();

            var guestStay = await unitOfWork.GetWriteRepository<GuestStay>().AddAsync(guestStayMap);

            await unitOfWork.SaveAsync();

            var customerMap = mapper.Map<Customer, CustomerRequestDto>(request.CustomerRequestDto);

            var customer = await unitOfWork.GetWriteRepository<Customer>().AddAsync(customerMap);

            customer.GuestStayId = guestStay.Id;

            await unitOfWork.SaveAsync();

            room.IsFull = true;

            await unitOfWork.GetWriteRepository<Room>().UpdateAsync(room);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateCustomerCommandResponse>().Success();

        }
    }
}

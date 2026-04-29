using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByGuestStayId
{
    public class CreateCustomerByGuestStayIdHandler : BaseHandler, IRequestHandler<CreateCustomerByGuestStayIdRequest, ResponseDto<CreateCustomerByGuestStayIdResponse>>
    {
        public CreateCustomerByGuestStayIdHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateCustomerByGuestStayIdResponse>> Handle(CreateCustomerByGuestStayIdRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<GuestStay>().GetAsync(y => y.IsActive && y.Id == request.GuestStayId);

            var mapEntity = mapper.Map<Customer, CreateCustomerByGuestStayIdRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<Customer>().AddAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateCustomerByGuestStayIdResponse>();
        }
    }
}

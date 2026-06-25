using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByGuestStayId
{
/// <summary>
/// CreateCustomerByGuestStayIdHandler sınıfını temsil eder.
/// </summary>
public class CreateCustomerByGuestStayIdHandler : BaseHandler, IRequestHandler<CreateCustomerByGuestStayIdRequest, ResponseDto<CreateCustomerByGuestStayIdResponse>>
    {
/// <summary>
/// CreateCustomerByGuestStayIdHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateCustomerByGuestStayIdHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
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

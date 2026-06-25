using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestStays.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.GuestStays.Commands.UpdatedCustomer
{
/// <summary>
/// UpdatedCustomerCommandHandler sınıfını temsil eder.
/// </summary>
public class UpdatedCustomerCommandHandler : BaseHandler, IRequestHandler<UpdatedCustomerCommandRequest, ResponseDto<UpdatedCustomerCommandResponse>>
    {
        private readonly GuestStayRule _guestStayRule;
/// <summary>
/// UpdatedCustomerCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdatedCustomerCommandHandler(GuestStayRule guestStayRule, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _guestStayRule = guestStayRule;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdatedCustomerCommandResponse>> Handle(UpdatedCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>().GetAsync(y => y.Id == request.Id && y.IsActive);

            await _guestStayRule.ControllCheckInAndCheckOutDates(request);

            var mapEntity = mapper.Map<GuestStay, UpdatedCustomerCommandRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<GuestStay>().UpdateAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdatedCustomerCommandResponse>().Success();

        }
    }
}

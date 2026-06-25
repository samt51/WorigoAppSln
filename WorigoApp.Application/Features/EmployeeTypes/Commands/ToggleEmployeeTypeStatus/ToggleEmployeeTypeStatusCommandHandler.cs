using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus
{
/// <summary>
/// ToggleEmployeeTypeStatusCommandHandler sınıfını temsil eder.
/// </summary>
public class ToggleEmployeeTypeStatusCommandHandler : BaseHandler, IRequestHandler<ToggleEmployeeTypeStatusCommandRequest, ResponseDto<ToggleEmployeeTypeStatusCommandResponse>>
    {
/// <summary>
/// ToggleEmployeeTypeStatusCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public ToggleEmployeeTypeStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<ToggleEmployeeTypeStatusCommandResponse>> Handle(ToggleEmployeeTypeStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var employeeType = await unitOfWork.GetReadRepository<EmployeeType>()
                .GetAsync(x => x.Id == request.EmployeeTypeId && !x.IsDeleted, enableTracking: true);

            employeeType.IsActive = request.IsActive;

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<EmployeeType>().UpdateAsync(employeeType);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<ToggleEmployeeTypeStatusCommandResponse>().Success(new ToggleEmployeeTypeStatusCommandResponse
            {
                EmployeeTypeId = employeeType.Id,
                IsActive = employeeType.IsActive
            });
        }
    }
}

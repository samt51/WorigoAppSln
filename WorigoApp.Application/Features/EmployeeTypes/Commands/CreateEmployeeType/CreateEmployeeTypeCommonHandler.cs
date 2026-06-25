using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType
{
/// <summary>
/// CreateEmployeeTypeCommonHandler sınıfını temsil eder.
/// </summary>
public class CreateEmployeeTypeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeTypeCommonRequest, ResponseDto<CreateEmployeeTypeCommonResponse>>
    {
/// <summary>
/// CreateEmployeeTypeCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateEmployeeTypeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateEmployeeTypeCommonResponse>> Handle(CreateEmployeeTypeCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId);

            var creatMapper = mapper.Map<EmployeeType, CreateEmployeeTypeCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<EmployeeType>().AddAsync(creatMapper);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateEmployeeTypeCommonResponse>().Success();

        }
    }
}

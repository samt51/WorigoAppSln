using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Commands.CreateDepartment
{
/// <summary>
/// CreateDepartmentCommonHandler sınıfını temsil eder.
/// </summary>
public class CreateDepartmentCommonHandler : BaseHandler, IRequestHandler<CreateDepartmentCommonRequest, ResponseDto<CreateDepartmentCommonResponse>>
    {
/// <summary>
/// CreateDepartmentCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateDepartmentCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateDepartmentCommonResponse>> Handle(CreateDepartmentCommonRequest request, CancellationToken cancellationToken)
        {
            var hoteIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            var map = mapper.Map<Department, CreateDepartmentCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var saveEntity = await unitOfWork.GetWriteRepository<Department>().AddAsync(map);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateDepartmentCommonResponse>().Success();
        }
    }
}

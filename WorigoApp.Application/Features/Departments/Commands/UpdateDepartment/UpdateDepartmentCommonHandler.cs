using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Commands.UpdateDepartment
{
/// <summary>
/// UpdateDepartmentCommonHandler sınıfını temsil eder.
/// </summary>
public class UpdateDepartmentCommonHandler : BaseHandler, IRequestHandler<UpdateDepartmentCommonRequest, ResponseDto<UpdateDepartmentCommonResponse>>
    {
/// <summary>
/// UpdateDepartmentCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateDepartmentCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateDepartmentCommonResponse>> Handle(UpdateDepartmentCommonRequest request, CancellationToken cancellationToken)
        {
            var findData = await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.Id);
 
            findData.Name = request.Name;
            findData.ModifyDate = DateTime.Now;

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<Department>().UpdateAsync(findData);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateDepartmentCommonResponse>().Success();
        }
    }
}

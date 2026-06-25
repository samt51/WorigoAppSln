using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
/// <summary>
/// GetAllDepartmentQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllDepartmentQueryHandler : BaseHandler, IRequestHandler<GetAllDepartmentQueryRequest, ResponseDto<IList<GetAllDepartmentQueryResponse>>>
    {
/// <summary>
/// GetAllDepartmentQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllDepartmentQueryResponse>>> Handle(GetAllDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync();

            var map = mapper.Map<GetAllDepartmentQueryResponse, Department>(departments);

            return new ResponseDto<IList<GetAllDepartmentQueryResponse>>().Success(map);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Queries.GetByIdDepartment
{
/// <summary>
/// GetByIdDepartmentQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdDepartmentQueryHandler : BaseHandler, IRequestHandler<GetByIdDepartmentQueryRequest, ResponseDto<GetByIdDepartmentQueryResponse>>
    {
/// <summary>
/// GetByIdDepartmentQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdDepartmentQueryResponse>> Handle(GetByIdDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId);

            var map = mapper.Map<GetByIdDepartmentQueryResponse, Department>(data);

            return new ResponseDto<GetByIdDepartmentQueryResponse>().Success(map);
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
/// <summary>
/// GetAllEmployeeTypesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllEmployeeTypesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeeTypesQueryRequest, ResponseDto<IList<GetAllEmployeeTypesQueryResponse>>>
    {
/// <summary>
/// GetAllEmployeeTypesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllEmployeeTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllEmployeeTypesQueryResponse>>> Handle(GetAllEmployeeTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<EmployeeType>().GetAllAsync(x => x.DepartmentId == request.DepartmentId, y => y.Include(x => x.Department));
       
            var map = mapper.Map<GetAllEmployeeTypesQueryResponse, EmployeeType>(employeeList);

            return new ResponseDto<IList<GetAllEmployeeTypesQueryResponse>>().Success(map);
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeeTypesQueryRequest, IList<GetAllEmployeeTypesQueryResponse>>
    {
        public GetAllEmployeeTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllEmployeeTypesQueryResponse>> Handle(GetAllEmployeeTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<EmployeeType>().GetAllAsync(x => x.DepartmentId == request.DepartmentId, y => y.Include(x => x.Department));
            mapper.Map<GetAllDepartmentQueryResponse, Department>(employeeList.Select(x => x.Department).FirstOrDefault());

            return mapper.Map<GetAllEmployeeTypesQueryResponse, EmployeeType>(employeeList);
        }
    }
}

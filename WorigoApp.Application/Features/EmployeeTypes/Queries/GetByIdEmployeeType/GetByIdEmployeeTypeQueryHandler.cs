using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Departments.Queries.GetAllDepartment;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetByIdEmployeeType
{
    public class GetByIdEmployeeTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdEmployeeTypeQueryRequest, Response<GetByIdEmployeeTypeQueryResponse>>
    {
        public GetByIdEmployeeTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdEmployeeTypeQueryResponse>> Handle(GetByIdEmployeeTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.EmployeeTypeId && !x.IsDeleted, y => y.Include(x => x.Department));

            mapper.Map<GetAllDepartmentQueryResponse, Department>(data.Department);

            var map = mapper.Map<GetByIdEmployeeTypeQueryResponse, EmployeeType>(data);

            return new Response<GetByIdEmployeeTypeQueryResponse>().Success(map);
        }
    }
}

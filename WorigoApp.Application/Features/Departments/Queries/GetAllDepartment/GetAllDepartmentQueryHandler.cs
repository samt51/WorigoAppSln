using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
    public class GetAllDepartmentQueryHandler : BaseHandler, IRequestHandler<GetAllDepartmentQueryRequest, Response<IList<GetAllDepartmentQueryResponse>>>
    {
        public GetAllDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
        public async Task<Response<IList<GetAllDepartmentQueryResponse>>> Handle(GetAllDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync();

            var map = mapper.Map<GetAllDepartmentQueryResponse, Department>(departments);

            return new Response<IList<GetAllDepartmentQueryResponse>>().Success(map);
        }
    }
}

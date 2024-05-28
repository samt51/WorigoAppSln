using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Queries.GetByIdDepartment
{
    public class GetByIdDepartmentQueryHandler : BaseHandler, IRequestHandler<GetByIdDepartmentQueryRequest, Response<GetByIdDepartmentQueryResponse>>
    {
        public GetByIdDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdDepartmentQueryResponse>> Handle(GetByIdDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.DepartmentId);

            var map = mapper.Map<GetByIdDepartmentQueryResponse, EmployeeType>(data);

            return new Response<GetByIdDepartmentQueryResponse>().Success(map);
        }
    }
}

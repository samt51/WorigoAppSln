using MediatR;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Application.Pipelines;
using WorigoApp.Application.Pipelines.Caching;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
    public class GetAllDepartmentQueryHandler : BaseHandler, IRequestHandler<GetAllDepartmentQueryRequest, Response<IList<GetAllDepartmentQueryResponse>>>,ICachableRequest
    {

        public GetAllDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            
        }

        public string CacheKey => "GetAllDepartmentQuery(0,2)";

        public bool ByPassCache { get; }

        public TimeSpan? SlidingExpiration { get; }

        public string? CacheGroupKey => "GetDepartments";

        public async Task<Response<IList<GetAllDepartmentQueryResponse>>> Handle(GetAllDepartmentQueryRequest request, CancellationToken cancellationToken)
        {

            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync();


            var mapping = mapper.Map<GetAllDepartmentQueryResponse, Department>(departments);



            return new Response<IList<GetAllDepartmentQueryResponse>>().Success(mapping);
        }
    }
}

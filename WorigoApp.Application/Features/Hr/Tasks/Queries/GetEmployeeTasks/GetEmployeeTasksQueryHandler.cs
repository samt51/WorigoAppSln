using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks
{
    public class GetEmployeeTasksQueryHandler : BaseHandler, IRequestHandler<GetEmployeeTasksQueryRequest, ResponseDto<IList<GetEmployeeTasksQueryResponse>>>
    {
        public GetEmployeeTasksQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetEmployeeTasksQueryResponse>>> Handle(GetEmployeeTasksQueryRequest request, CancellationToken cancellationToken)
        {
            var tasks = await unitOfWork.GetReadRepository<EmployeeTask>().GetAllAsync(
                x => !x.IsDeleted &&
                     (!request.EmployeeId.HasValue || x.AssignedEmployeeId == request.EmployeeId) &&
                     (!request.DepartmentId.HasValue || x.DepartmentId == request.DepartmentId),
                orderBy: x => x.OrderByDescending(y => y.CreatedDate));

            var response = tasks.Select(x => new GetEmployeeTasksQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Priority = x.Priority,
                Status = x.Status,
                DueAt = x.DueAt
            }).ToList();

            return new ResponseDto<IList<GetEmployeeTasksQueryResponse>>().Success(response);
        }
    }
}

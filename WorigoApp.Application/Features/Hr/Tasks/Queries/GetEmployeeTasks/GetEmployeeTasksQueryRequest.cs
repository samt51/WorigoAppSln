using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks
{
    public class GetEmployeeTasksQueryRequest : IRequest<ResponseDto<IList<GetEmployeeTasksQueryResponse>>>
    {
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
    }
}

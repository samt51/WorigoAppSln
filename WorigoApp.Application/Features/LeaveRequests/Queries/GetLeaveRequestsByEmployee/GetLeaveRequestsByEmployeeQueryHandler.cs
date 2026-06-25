using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByEmployee
{
/// <summary>
/// GetLeaveRequestsByEmployeeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetLeaveRequestsByEmployeeQueryHandler : BaseHandler, IRequestHandler<GetLeaveRequestsByEmployeeQueryRequest, ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>>
    {
/// <summary>
/// GetLeaveRequestsByEmployeeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetLeaveRequestsByEmployeeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>> Handle(GetLeaveRequestsByEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await unitOfWork.GetReadRepository<LeaveRequest>().GetAllAsync(
                x => x.EmployeeId == request.EmployeeId && !x.IsDeleted,
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = leaveRequests.Select(x => new GetLeaveRequestsByEmployeeQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                LeaveType = x.LeaveType,
                Status = x.Status,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                TotalDayCount = x.TotalDayCount,
                ManagerNote = x.ManagerNote,
                HrNote = x.HrNote
            }).ToList();

            return new ResponseDto<IList<GetLeaveRequestsByEmployeeQueryResponse>>().Success(response);
        }
    }
}

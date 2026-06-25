using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee
{
/// <summary>
/// GetAttendanceByEmployeeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAttendanceByEmployeeQueryHandler : BaseHandler, IRequestHandler<GetAttendanceByEmployeeQueryRequest, ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>>
    {
/// <summary>
/// GetAttendanceByEmployeeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAttendanceByEmployeeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>> Handle(GetAttendanceByEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var records = await unitOfWork.GetReadRepository<AttendanceRecord>().GetAllAsync(
                x => x.EmployeeId == request.EmployeeId && !x.IsDeleted,
                orderBy: x => x.OrderByDescending(y => y.WorkDate));

            var response = records.Select(x => new GetAttendanceByEmployeeQueryResponse
            {
                Id = x.Id,
                WorkDate = x.WorkDate,
                CheckInAt = x.CheckInAt,
                CheckOutAt = x.CheckOutAt,
                Status = x.Status,
                LateMinutes = x.LateMinutes,
                OvertimeMinutes = x.OvertimeMinutes,
                Note = x.Note
            }).ToList();

            return new ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>().Success(response);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee
{
/// <summary>
/// GetAttendanceByEmployeeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAttendanceByEmployeeQueryRequest : IRequest<ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord
{
    public class UpsertAttendanceRecordCommandHandler : BaseHandler, IRequestHandler<UpsertAttendanceRecordCommandRequest, ResponseDto<UpsertAttendanceRecordCommandResponse>>
    {
        public UpsertAttendanceRecordCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpsertAttendanceRecordCommandResponse>> Handle(UpsertAttendanceRecordCommandRequest request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.GetReadRepository<Employee>().GetAsync(
                x => x.Id == request.EmployeeId && x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.EmployeeType).ThenInclude(y => y.Department).Include(y => y.Shift));

            var existing = await unitOfWork.GetReadRepository<AttendanceRecord>().FindAsync(
                x => x.EmployeeId == request.EmployeeId && x.WorkDate.Date == request.WorkDate.Date && !x.IsDeleted);

            var plannedStart = employee.Shift?.StartTime;
            var plannedEnd = employee.Shift?.EndTime;

            var lateMinutes = 0;
            if (request.CheckInAt.HasValue && plannedStart.HasValue)
            {
                lateMinutes = Math.Max((int)(request.CheckInAt.Value - request.WorkDate.Date.Add(plannedStart.Value)).TotalMinutes, 0);
            }

            var overtimeMinutes = 0;
            if (request.CheckOutAt.HasValue && plannedEnd.HasValue)
            {
                overtimeMinutes = Math.Max((int)(request.CheckOutAt.Value - request.WorkDate.Date.Add(plannedEnd.Value)).TotalMinutes, 0);
            }

            var status = request.Status ?? (lateMinutes > 0 ? AttendanceStatusEnum.Late : AttendanceStatusEnum.Present);

            if (existing is null)
            {
                existing = await unitOfWork.GetWriteRepository<AttendanceRecord>().AddAsync(new AttendanceRecord
                {
                    HotelId = request.HotelId,
                    EmployeeId = request.EmployeeId,
                    DepartmentId = employee.EmployeeType?.DepartmentId,
                    ShiftId = employee.ShiftId,
                    WorkDate = request.WorkDate.Date,
                    PlannedStartTime = plannedStart,
                    PlannedEndTime = plannedEnd,
                    CheckInAt = request.CheckInAt,
                    CheckOutAt = request.CheckOutAt,
                    Status = status,
                    LateMinutes = lateMinutes,
                    OvertimeMinutes = overtimeMinutes,
                    Note = request.Note
                });
            }
            else
            {
                existing.CheckInAt = request.CheckInAt ?? existing.CheckInAt;
                existing.CheckOutAt = request.CheckOutAt ?? existing.CheckOutAt;
                existing.Status = status;
                existing.LateMinutes = lateMinutes;
                existing.OvertimeMinutes = overtimeMinutes;
                existing.Note = request.Note ?? existing.Note;
                await unitOfWork.GetWriteRepository<AttendanceRecord>().UpdateAsync(existing);
            }

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpsertAttendanceRecordCommandResponse>().Success(new UpsertAttendanceRecordCommandResponse
            {
                Id = existing.Id,
                Status = existing.Status,
                LateMinutes = existing.LateMinutes,
                OvertimeMinutes = existing.OvertimeMinutes
            });
        }
    }
}

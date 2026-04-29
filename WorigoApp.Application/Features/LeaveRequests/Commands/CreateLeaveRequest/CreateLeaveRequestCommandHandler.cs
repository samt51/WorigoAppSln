using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommandHandler : BaseHandler, IRequestHandler<CreateLeaveRequestCommandRequest, ResponseDto<CreateLeaveRequestCommandResponse>>
    {
        public CreateLeaveRequestCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateLeaveRequestCommandResponse>> Handle(CreateLeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.EndDate.Date < request.StartDate.Date)
            {
                return new ResponseDto<CreateLeaveRequestCommandResponse>()
                    .Fail(new List<string> { "Izin bitis tarihi baslangic tarihinden once olamaz." }, 400);
            }

            var employee = await unitOfWork.GetReadRepository<Employee>().GetAsync(
                x => x.Id == request.EmployeeId && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted,
                include: x => x.Include(y => y.EmployeeType).ThenInclude(y => y.Department));

            if (request.HrEmployeeId.HasValue)
            {
                await unitOfWork.GetReadRepository<Employee>().GetAsync(
                    x => x.Id == request.HrEmployeeId.Value && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);
            }

            var departmentId = employee.EmployeeType?.DepartmentId;
            Department? department = null;
            if (departmentId.HasValue)
            {
                department = await unitOfWork.GetReadRepository<Department>().FindAsync(
                    x => x.Id == departmentId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var totalDays = (decimal)(request.EndDate.Date - request.StartDate.Date).TotalDays + 1;
            var status = request.HrEmployeeId.HasValue
                ? Domain.Enums.LeaveRequestStatusEnum.PendingManagerApproval
                : Domain.Enums.LeaveRequestStatusEnum.PendingManagerApproval;

            var entity = new LeaveRequest
            {
                HotelId = request.HotelId,
                EmployeeId = request.EmployeeId,
                DepartmentId = departmentId,
                ManagerEmployeeId = department?.ManagerEmployeeId,
                HrEmployeeId = request.HrEmployeeId,
                LeaveType = request.LeaveType,
                Title = request.Title,
                Reason = request.Reason,
                StartDate = request.StartDate.Date,
                EndDate = request.EndDate.Date,
                TotalDayCount = totalDays,
                Status = status,
                RequestedAt = DateTime.UtcNow
            };

            var created = await unitOfWork.GetWriteRepository<LeaveRequest>().AddAsync(entity);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateLeaveRequestCommandResponse>().Success(new CreateLeaveRequestCommandResponse
            {
                Id = created.Id,
                Status = created.Status,
                TotalDayCount = created.TotalDayCount,
                RequestedAt = created.RequestedAt
            });
        }
    }
}

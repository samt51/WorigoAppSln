using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.CreateLeaveRequest
{
/// <summary>
/// CreateLeaveRequestCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateLeaveRequestCommandHandler : BaseHandler, IRequestHandler<CreateLeaveRequestCommandRequest, ResponseDto<CreateLeaveRequestCommandResponse>>
    {
/// <summary>
/// CreateLeaveRequestCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateLeaveRequestCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateLeaveRequestCommandResponse>> Handle(CreateLeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var currentUser = await unitOfWork.GetReadRepository<Users>().GetAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(u => u.Employee));

            if (currentUser == null)
            {
                return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "Kullanıcı bulunamadı." }, 401);
            }

            bool isSystemAdmin = currentUser.RoleId == 1;
            bool isHotelAdmin = currentUser.RoleId == 2;
            bool isHrManager = currentUser.RoleId == 7;

            int targetEmployeeId = request.EmployeeId > 0 ? request.EmployeeId : (currentUser.Employee?.Id ?? 0);
            if (targetEmployeeId == 0)
            {
                return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "İzin talep edilecek personel belirlenemedi." }, 400);
            }

            if (currentUser.Employee == null || currentUser.Employee.Id != targetEmployeeId)
            {
                bool hasPrivilegedAccess = isSystemAdmin || (currentUser.Employee != null && (isHotelAdmin || isHrManager) && currentUser.Employee.HotelId == request.HotelId);
                if (!hasPrivilegedAccess)
                {
                    return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "Başka bir çalışan adına izin talebi oluşturma yetkiniz yok." }, 403);
                }
            }
            else
            {
                if (currentUser.Employee.HotelId != request.HotelId)
                {
                    return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "Çalıştığınız otel dışında izin talebinde bulunamazsınız." }, 403);
                }
            }

            if (request.EndDate.Date < request.StartDate.Date)
            {
                return new ResponseDto<CreateLeaveRequestCommandResponse>()
                    .Fail(new List<string> { "Izin bitis tarihi baslangic tarihinden once olamaz." }, 400);
            }

            var employee = await unitOfWork.GetReadRepository<Employee>().GetAsync(
                x => x.Id == targetEmployeeId && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted,
                include: x => x.Include(y => y.EmployeeType).ThenInclude(y => y.Department));

            if (employee == null)
            {
                return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "Personel kaydı bulunamadı." }, 404);
            }

            if (request.HrEmployeeId.HasValue)
            {
                var hrEmp = await unitOfWork.GetReadRepository<Employee>().GetAsync(
                    x => x.Id == request.HrEmployeeId.Value && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);
                if (hrEmp == null)
                {
                    return new ResponseDto<CreateLeaveRequestCommandResponse>().Fail(new List<string> { "Seçilen IK sorumlusu bulunamadı." }, 400);
                }
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
                EmployeeId = targetEmployeeId,
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

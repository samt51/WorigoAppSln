using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
/// <summary>
/// UpdateLeaveRequestStatusCommandHandler sınıfını temsil eder.
/// </summary>
public class UpdateLeaveRequestStatusCommandHandler : BaseHandler, IRequestHandler<UpdateLeaveRequestStatusCommandRequest, ResponseDto<UpdateLeaveRequestStatusCommandResponse>>
    {
/// <summary>
/// UpdateLeaveRequestStatusCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateLeaveRequestStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateLeaveRequestStatusCommandResponse>> Handle(UpdateLeaveRequestStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var currentUser = await unitOfWork.GetReadRepository<Users>().GetAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(u => u.Employee));

            if (currentUser == null)
            {
                return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>().Fail(new List<string> { "Kullanıcı bulunamadı." }, 401);
            }

            bool isSystemAdmin = currentUser.RoleId == 1;
            bool isHotelAdmin = currentUser.RoleId == 2;
            bool isHrManager = currentUser.RoleId == 7;

            var leaveRequest = await unitOfWork.GetReadRepository<LeaveRequest>().GetAsync(x => x.Id == request.LeaveRequestId && !x.IsDeleted);
            if (leaveRequest == null)
            {
                return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>().Fail(new List<string> { "İzin talebi bulunamadı." }, 404);
            }

            if (!isSystemAdmin && currentUser.Employee != null && leaveRequest.HotelId != currentUser.Employee.HotelId)
            {
                return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>().Fail(new List<string> { "Bu oteldeki izin talebine müdahale etme yetkiniz yok." }, 403);
            }

            int? currentEmployeeId = currentUser.Employee?.Id;

            if (request.IsHrAction)
            {
                bool canHrApprove = isSystemAdmin || (currentUser.Employee != null && (isHotelAdmin || isHrManager || leaveRequest.HrEmployeeId == currentEmployeeId));
                if (!canHrApprove)
                {
                    return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>()
                        .Fail(new List<string> { "Bu izin talebi için IK onay yetkisi bulunmuyor." }, 403);
                }

                leaveRequest.HrActionAt = DateTime.UtcNow;
                leaveRequest.HrNote = request.Note;
                leaveRequest.Status = request.Status;
            }
            else
            {
                bool canManagerApprove = isSystemAdmin || (currentUser.Employee != null && (isHotelAdmin || leaveRequest.ManagerEmployeeId == currentEmployeeId));
                if (!canManagerApprove)
                {
                    return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>()
                        .Fail(new List<string> { "Bu izin talebi için müdür onay yetkisi bulunmuyor." }, 403);
                }

                leaveRequest.ManagerActionAt = DateTime.UtcNow;
                leaveRequest.ManagerNote = request.Note;

                if (request.Status == LeaveRequestStatusEnum.Approved && leaveRequest.HrEmployeeId.HasValue)
                {
                    leaveRequest.Status = LeaveRequestStatusEnum.PendingHrApproval;
                }
                else
                {
                    leaveRequest.Status = request.Status;
                }
            }

            await unitOfWork.GetWriteRepository<LeaveRequest>().UpdateAsync(leaveRequest);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>().Success(new UpdateLeaveRequestStatusCommandResponse
            {
                Id = leaveRequest.Id,
                Status = leaveRequest.Status,
                ManagerActionAt = leaveRequest.ManagerActionAt,
                HrActionAt = leaveRequest.HrActionAt
            });
        }
    }
}

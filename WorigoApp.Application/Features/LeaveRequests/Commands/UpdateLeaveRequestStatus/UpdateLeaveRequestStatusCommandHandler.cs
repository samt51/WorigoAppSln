using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.LeaveRequests.Commands.UpdateLeaveRequestStatus
{
    public class UpdateLeaveRequestStatusCommandHandler : BaseHandler, IRequestHandler<UpdateLeaveRequestStatusCommandRequest, ResponseDto<UpdateLeaveRequestStatusCommandResponse>>
    {
        public UpdateLeaveRequestStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateLeaveRequestStatusCommandResponse>> Handle(UpdateLeaveRequestStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await unitOfWork.GetReadRepository<LeaveRequest>().GetAsync(x => x.Id == request.LeaveRequestId && !x.IsDeleted);

            if (request.IsHrAction)
            {
                if (leaveRequest.HrEmployeeId != request.ActionEmployeeId)
                {
                    return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>()
                        .Fail(new List<string> { "Bu izin talebi icin IK onay yetkisi bulunmuyor." }, 403);
                }

                leaveRequest.HrActionAt = DateTime.UtcNow;
                leaveRequest.HrNote = request.Note;
                leaveRequest.Status = request.Status;
            }
            else
            {
                if (leaveRequest.ManagerEmployeeId != request.ActionEmployeeId)
                {
                    return new ResponseDto<UpdateLeaveRequestStatusCommandResponse>()
                        .Fail(new List<string> { "Bu izin talebi icin mudur onay yetkisi bulunmuyor." }, 403);
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

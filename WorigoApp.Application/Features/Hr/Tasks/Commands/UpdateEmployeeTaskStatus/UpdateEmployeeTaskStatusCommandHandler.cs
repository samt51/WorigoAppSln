using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus
{
    public class UpdateEmployeeTaskStatusCommandHandler : BaseHandler, IRequestHandler<UpdateEmployeeTaskStatusCommandRequest, ResponseDto<UpdateEmployeeTaskStatusCommandResponse>>
    {
        public UpdateEmployeeTaskStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateEmployeeTaskStatusCommandResponse>> Handle(UpdateEmployeeTaskStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var task = await unitOfWork.GetReadRepository<EmployeeTask>().GetAsync(x => x.Id == request.EmployeeTaskId && !x.IsDeleted);

            task.Status = request.Status;
            if (request.Status == EmployeeTaskStatusEnum.InProgress && !task.StartedAt.HasValue)
            {
                task.StartedAt = DateTime.UtcNow;
            }

            if (request.Status == EmployeeTaskStatusEnum.Completed)
            {
                task.CompletedAt = DateTime.UtcNow;
                task.CompletionNote = request.CompletionNote;
            }

            await unitOfWork.GetWriteRepository<EmployeeTask>().UpdateAsync(task);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateEmployeeTaskStatusCommandResponse>().Success(new UpdateEmployeeTaskStatusCommandResponse
            {
                Id = task.Id,
                Status = task.Status,
                StartedAt = task.StartedAt,
                CompletedAt = task.CompletedAt
            });
        }
    }
}

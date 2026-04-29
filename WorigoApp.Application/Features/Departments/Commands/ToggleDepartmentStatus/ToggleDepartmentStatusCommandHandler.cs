using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus
{
    public class ToggleDepartmentStatusCommandHandler : BaseHandler, IRequestHandler<ToggleDepartmentStatusCommandRequest, ResponseDto<ToggleDepartmentStatusCommandResponse>>
    {
        public ToggleDepartmentStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<ToggleDepartmentStatusCommandResponse>> Handle(ToggleDepartmentStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var department = await unitOfWork.GetReadRepository<Department>()
                .GetAsync(x => x.Id == request.DepartmentId && !x.IsDeleted, enableTracking: true);

            department.IsActive = request.IsActive;

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<Department>().UpdateAsync(department);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<ToggleDepartmentStatusCommandResponse>().Success(new ToggleDepartmentStatusCommandResponse
            {
                DepartmentId = department.Id,
                IsActive = department.IsActive
            });
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.CreateEmployeeTask
{
    public class CreateEmployeeTaskCommandHandler : BaseHandler, IRequestHandler<CreateEmployeeTaskCommandRequest, ResponseDto<CreateEmployeeTaskCommandResponse>>
    {
        public CreateEmployeeTaskCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateEmployeeTaskCommandResponse>> Handle(CreateEmployeeTaskCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.AssignedEmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.AssignedByEmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);

            if (request.DepartmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            if (request.RelatedServiceRequestId.HasValue)
            {
                await unitOfWork.GetReadRepository<ServiceRequest>().GetAsync(x => x.Id == request.RelatedServiceRequestId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var entity = await unitOfWork.GetWriteRepository<EmployeeTask>().AddAsync(new EmployeeTask
            {
                HotelId = request.HotelId,
                AssignedEmployeeId = request.AssignedEmployeeId,
                AssignedByEmployeeId = request.AssignedByEmployeeId,
                DepartmentId = request.DepartmentId,
                RelatedServiceRequestId = request.RelatedServiceRequestId,
                Title = request.Title,
                Description = request.Description,
                Priority = request.Priority,
                DueAt = request.DueAt
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateEmployeeTaskCommandResponse>().Success(new CreateEmployeeTaskCommandResponse
            {
                Id = entity.Id,
                DueAt = entity.DueAt
            });
        }
    }
}

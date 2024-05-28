using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommonHandler : BaseHandler, IRequestHandler<UpdateDepartmentCommonRequest, Response<UpdateDepartmentCommonResponse>>
    {
        public UpdateDepartmentCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
        public async Task<Response<UpdateDepartmentCommonResponse>> Handle(UpdateDepartmentCommonRequest request, CancellationToken cancellationToken)
        {
            var findData = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.Id);
 
            findData.Name = request.Name;
            findData.ModifyDate = DateTime.Now;

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<EmployeeType>().UpdateAsync(findData);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateDepartmentCommonResponse>().Success();
        }
    }
}

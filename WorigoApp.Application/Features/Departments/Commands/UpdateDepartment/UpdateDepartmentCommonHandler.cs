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
            var findData = await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.Id);

            if (findData is null)
            {
                return new Response<UpdateDepartmentCommonResponse>().Fail(new UpdateDepartmentCommonResponse(), "Deparment Unfined", 400);
            }
            findData.Name = request.Name;
            findData.ModifyDate = DateTime.Now;

            unitOfWork.OpenTransaction();

            var modifyEntity = await unitOfWork.GetWriteRepository<Department>().UpdateAsync(findData);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateDepartmentCommonResponse>().Success();
            }
            return new Response<UpdateDepartmentCommonResponse>().Fail(new UpdateDepartmentCommonResponse(), "error", 400);

        }
    }
}

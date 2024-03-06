using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType
{
    public class UpdateEmployeeTypeCommonHandler : BaseHandler, IRequestHandler<UpdateEmployeeTypeCommonRequest, Response<UpdateEmployeeTypeCommonResponse>>
    {
        public UpdateEmployeeTypeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateEmployeeTypeCommonResponse>> Handle(UpdateEmployeeTypeCommonRequest request, CancellationToken cancellationToken)
        {
            var dataIsControll = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.Id);

            if (dataIsControll is null)
            {
                return new Response<UpdateEmployeeTypeCommonResponse>().Fail(new UpdateEmployeeTypeCommonResponse(), "Data Undifined", 400);
            }

            dataIsControll.Name = request.Name;
            unitOfWork.OpenTransaction();

            var entity = await unitOfWork.GetWriteRepository<EmployeeType>().UpdateAsync(dataIsControll);
            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateEmployeeTypeCommonResponse>().Success();
            }
            return new Response<UpdateEmployeeTypeCommonResponse>().Fail(new UpdateEmployeeTypeCommonResponse(), "", 400);
        }
    }
}

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

            dataIsControll.Name = request.Name;
            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<EmployeeType>().UpdateAsync(dataIsControll);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateEmployeeTypeCommonResponse>().Success();
        }
    }
}

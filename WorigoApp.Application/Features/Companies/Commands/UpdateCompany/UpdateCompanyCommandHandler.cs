using MediatR;
using MediatR.Pipeline;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandHandler : BaseHandler, IRequestHandler<UpdateCompanyCommandRequest, Response<UpdateCompanyCommandResponse>>
    {
        public UpdateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }

        public async Task<Response<UpdateCompanyCommandResponse>> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var dataFind = await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Id);

            if (dataFind is null)
                return new Response<UpdateCompanyCommandResponse>().Fail(new UpdateCompanyCommandResponse(), "Data Is Null", 200);

            dataFind.Name = request.Name;
            var update = await unitOfWork.GetWriteRepository<Company>().UpdateAsync(dataFind);
            unitOfWork.OpenTransaction();
            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateCompanyCommandResponse>().Success();
            }
            return new Response<UpdateCompanyCommandResponse>();
        }
    }
}

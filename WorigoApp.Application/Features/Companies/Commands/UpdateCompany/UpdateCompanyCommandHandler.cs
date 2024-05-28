using MediatR;
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

            dataFind.Name = request.Name;

            await unitOfWork.GetWriteRepository<Company>().UpdateAsync(dataFind);

            unitOfWork.OpenTransaction();

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateCompanyCommandResponse>().Success();
        }
    }
}

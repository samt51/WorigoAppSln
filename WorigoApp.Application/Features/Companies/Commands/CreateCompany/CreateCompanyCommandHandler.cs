using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommandHandler : BaseHandler, IRequestHandler<CreateCompanyCommandRequest, Response<CreateCompanyCommandResponse>>
    {
        public CreateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
        public async Task<Response<CreateCompanyCommandResponse>> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var map = mapper.Map<Company, CreateCompanyCommandRequest>(request);

            unitOfWork.OpenTransaction();

            var saveEntity = await unitOfWork.GetWriteRepository<Company>().AddAsync(map);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                var result = mapper.Map<CreateCompanyCommandResponse, Company>(saveEntity);
                return new Response<CreateCompanyCommandResponse>().Success(result);
            }
            return new Response<CreateCompanyCommandResponse>();
        }
    }
}

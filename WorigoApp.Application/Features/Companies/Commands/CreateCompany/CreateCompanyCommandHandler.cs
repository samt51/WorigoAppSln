using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Commands.CreateCompany
{
/// <summary>
/// CreateCompanyCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateCompanyCommandHandler : BaseHandler, IRequestHandler<CreateCompanyCommandRequest, ResponseDto<CreateCompanyCommandResponse>>
    {
/// <summary>
/// CreateCompanyCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateCompanyCommandResponse>> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var map = mapper.Map<Company, CreateCompanyCommandRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var saveEntity = await unitOfWork.GetWriteRepository<Company>().AddAsync(map);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            var result = mapper.Map<CreateCompanyCommandResponse, Company>(saveEntity);

            return new ResponseDto<CreateCompanyCommandResponse>().Success(result);
        }
    }
}

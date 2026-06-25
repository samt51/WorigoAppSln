using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Commands.UpdateCompany
{
/// <summary>
/// UpdateCompanyCommandHandler sınıfını temsil eder.
/// </summary>
public class UpdateCompanyCommandHandler : BaseHandler, IRequestHandler<UpdateCompanyCommandRequest, ResponseDto<UpdateCompanyCommandResponse>>
    {
/// <summary>
/// UpdateCompanyCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {

        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateCompanyCommandResponse>> Handle(UpdateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            var dataFind = await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Id);

            dataFind.Name = request.Name;

            await unitOfWork.GetWriteRepository<Company>().UpdateAsync(dataFind);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateCompanyCommandResponse>().Success();
        }
    }
}

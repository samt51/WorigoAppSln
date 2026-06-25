using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Commands.CreateCompany
{
/// <summary>
/// CreateCompanyCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateCompanyCommandRequest : IRequest<ResponseDto<CreateCompanyCommandResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// CreateCompanyCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateCompanyCommandRequest(string name)
        {
            this.Name = name;
        }
    }
}

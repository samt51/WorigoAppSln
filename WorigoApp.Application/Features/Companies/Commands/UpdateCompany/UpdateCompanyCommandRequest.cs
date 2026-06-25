using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Commands.UpdateCompany
{
/// <summary>
/// UpdateCompanyCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateCompanyCommandRequest : IRequest<ResponseDto<UpdateCompanyCommandResponse>>
    {
/// <summary>
/// UpdateCompanyCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateCompanyCommandRequest(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
    }
}

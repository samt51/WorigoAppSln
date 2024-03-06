using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommandRequest : IRequest<Response<CreateCompanyCommandResponse>>
    {
        public string Name { get; }
        public CreateCompanyCommandRequest(string name)
        {
            this.Name = name;
        }
    }
}

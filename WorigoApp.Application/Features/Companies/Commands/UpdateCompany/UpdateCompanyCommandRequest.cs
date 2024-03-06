using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommandRequest : IRequest<Response<UpdateCompanyCommandResponse>>
    {
        public UpdateCompanyCommandRequest(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
        public int Id { get; }
        public string Name { get; }
    }
}

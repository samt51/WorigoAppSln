using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaServices
{
    public class GetSpaServicesQueryRequest : IRequest<ResponseDto<IList<SpaService>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}

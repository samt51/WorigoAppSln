using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaSlots
{
    public class GetSpaSlotsQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
        public string Date { get; set; } = string.Empty;
        public string SessionToken { get; set; } = string.Empty;
    }
}

using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
    public class GetInternalAnnouncementsQueryRequest : IRequest<ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>>
    {
        public int HotelId { get; set; }
        public int? DepartmentId { get; set; }
    }
}

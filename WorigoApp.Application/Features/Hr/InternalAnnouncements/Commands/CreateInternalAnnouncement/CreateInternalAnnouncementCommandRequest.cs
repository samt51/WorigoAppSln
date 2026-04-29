using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Commands.CreateInternalAnnouncement
{
    public class CreateInternalAnnouncementCommandRequest : IRequest<ResponseDto<CreateInternalAnnouncementCommandResponse>>
    {
        public int HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public InternalAnnouncementAudienceEnum Audience { get; set; }
        public DateTime? ExpireAt { get; set; }
        public bool IsPinned { get; set; }
    }
}

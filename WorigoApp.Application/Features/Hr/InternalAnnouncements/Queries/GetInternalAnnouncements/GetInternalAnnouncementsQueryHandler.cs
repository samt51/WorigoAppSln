using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
    public class GetInternalAnnouncementsQueryHandler : BaseHandler, IRequestHandler<GetInternalAnnouncementsQueryRequest, ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>>
    {
        public GetInternalAnnouncementsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>> Handle(GetInternalAnnouncementsQueryRequest request, CancellationToken cancellationToken)
        {
            var announcements = await unitOfWork.GetReadRepository<InternalAnnouncement>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     (!request.DepartmentId.HasValue || x.DepartmentId == request.DepartmentId || x.Audience == InternalAnnouncementAudienceEnum.AllEmployees) &&
                     (!x.ExpireAt.HasValue || x.ExpireAt >= DateTime.UtcNow),
                orderBy: x => x.OrderByDescending(y => y.IsPinned).ThenByDescending(y => y.PublishAt));

            var response = announcements.Select(x => new GetInternalAnnouncementsQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                Audience = x.Audience,
                PublishAt = x.PublishAt,
                ExpireAt = x.ExpireAt,
                IsPinned = x.IsPinned
            }).ToList();

            return new ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>().Success(response);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements
{
/// <summary>
/// GetInternalAnnouncementsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetInternalAnnouncementsQueryHandler : BaseHandler, IRequestHandler<GetInternalAnnouncementsQueryRequest, ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>>
    {
/// <summary>
/// GetInternalAnnouncementsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetInternalAnnouncementsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>> Handle(GetInternalAnnouncementsQueryRequest request, CancellationToken cancellationToken)
        {
            var announcements = await unitOfWork.GetReadRepository<Announcement>().GetAllAsync(
                x => x.HotelId == request.HotelId &&
                     !x.IsDeleted &&
                     x.InternalAudience.HasValue &&
                     (!request.DepartmentId.HasValue || x.DepartmentId == request.DepartmentId || x.InternalAudience == InternalAnnouncementAudienceEnum.AllEmployees) &&
                     (!x.EndAt.HasValue || x.EndAt >= DateTime.UtcNow),
                orderBy: x => x.OrderByDescending(y => y.IsPinned).ThenByDescending(y => y.StartAt));

            var response = announcements.Select(x => new GetInternalAnnouncementsQueryResponse
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Description,
                Audience = x.InternalAudience.Value,
                PublishAt = x.StartAt,
                ExpireAt = x.EndAt,
                IsPinned = x.IsPinned
            }).ToList();

            return new ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>().Success(response);
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Commands.CreateInternalAnnouncement
{
/// <summary>
/// CreateInternalAnnouncementCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateInternalAnnouncementCommandHandler : BaseHandler, IRequestHandler<CreateInternalAnnouncementCommandRequest, ResponseDto<CreateInternalAnnouncementCommandResponse>>
    {
/// <summary>
/// CreateInternalAnnouncementCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateInternalAnnouncementCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateInternalAnnouncementCommandResponse>> Handle(CreateInternalAnnouncementCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.CreatedByEmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);

            if (request.DepartmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var entity = await unitOfWork.GetWriteRepository<Announcement>().AddAsync(new Announcement
            {
                HotelId = request.HotelId,
                DepartmentId = request.DepartmentId,
                CreatedByEmployeeId = request.CreatedByEmployeeId,
                Title = request.Title,
                Description = request.Content,
                InternalAudience = request.Audience,
                StartAt = DateTime.UtcNow,
                EndAt = request.ExpireAt,
                IsPinned = request.IsPinned,
                IsVisibleToGuest = false,
                Type = AnnouncementTypeEnum.Announcement
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateInternalAnnouncementCommandResponse>().Success(new CreateInternalAnnouncementCommandResponse
            {
                Id = entity.Id,
                PublishAt = entity.StartAt
            });
        }
    }
}

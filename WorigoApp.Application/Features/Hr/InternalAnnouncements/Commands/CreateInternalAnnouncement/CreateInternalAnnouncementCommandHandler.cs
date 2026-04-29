using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.InternalAnnouncements.Commands.CreateInternalAnnouncement
{
    public class CreateInternalAnnouncementCommandHandler : BaseHandler, IRequestHandler<CreateInternalAnnouncementCommandRequest, ResponseDto<CreateInternalAnnouncementCommandResponse>>
    {
        public CreateInternalAnnouncementCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateInternalAnnouncementCommandResponse>> Handle(CreateInternalAnnouncementCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.CreatedByEmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);

            if (request.DepartmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var entity = await unitOfWork.GetWriteRepository<InternalAnnouncement>().AddAsync(new InternalAnnouncement
            {
                HotelId = request.HotelId,
                DepartmentId = request.DepartmentId,
                CreatedByEmployeeId = request.CreatedByEmployeeId,
                Title = request.Title,
                Content = request.Content,
                Audience = request.Audience,
                PublishAt = DateTime.UtcNow,
                ExpireAt = request.ExpireAt,
                IsPinned = request.IsPinned
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateInternalAnnouncementCommandResponse>().Success(new CreateInternalAnnouncementCommandResponse
            {
                Id = entity.Id,
                PublishAt = entity.PublishAt
            });
        }
    }
}

using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Documents.Commands.CreateEmployeeDocument
{
    public class CreateEmployeeDocumentCommandHandler : BaseHandler, IRequestHandler<CreateEmployeeDocumentCommandRequest, ResponseDto<CreateEmployeeDocumentCommandResponse>>
    {
        public CreateEmployeeDocumentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateEmployeeDocumentCommandResponse>> Handle(CreateEmployeeDocumentCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.EmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);
            if (request.VerifiedByEmployeeId.HasValue)
            {
                await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.VerifiedByEmployeeId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var entity = await unitOfWork.GetWriteRepository<EmployeeDocument>().AddAsync(new EmployeeDocument
            {
                HotelId = request.HotelId,
                EmployeeId = request.EmployeeId,
                DocumentType = request.DocumentType,
                Title = request.Title,
                FileUrl = request.FileUrl,
                DocumentNumber = request.DocumentNumber,
                IssuedAt = request.IssuedAt,
                ExpireAt = request.ExpireAt,
                IsMandatory = request.IsMandatory,
                VerifiedByEmployeeId = request.VerifiedByEmployeeId,
                VerifiedAt = request.VerifiedByEmployeeId.HasValue ? DateTime.UtcNow : null,
                Note = request.Note
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateEmployeeDocumentCommandResponse>().Success(new CreateEmployeeDocumentCommandResponse
            {
                Id = entity.Id,
                ExpireAt = entity.ExpireAt
            });
        }
    }
}

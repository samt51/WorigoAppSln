using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments
{
    public class GetEmployeeDocumentsQueryHandler : BaseHandler, IRequestHandler<GetEmployeeDocumentsQueryRequest, ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>>
    {
        public GetEmployeeDocumentsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>> Handle(GetEmployeeDocumentsQueryRequest request, CancellationToken cancellationToken)
        {
            var documents = await unitOfWork.GetReadRepository<EmployeeDocument>().GetAllAsync(
                x => x.EmployeeId == request.EmployeeId && !x.IsDeleted,
                orderBy: x => x.OrderByDescending(y => y.CreatedDate));

            var response = documents.Select(x => new GetEmployeeDocumentsQueryResponse
            {
                Id = x.Id,
                DocumentType = x.DocumentType,
                Title = x.Title,
                FileUrl = x.FileUrl,
                ExpireAt = x.ExpireAt,
                IsMandatory = x.IsMandatory
            }).ToList();

            return new ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>().Success(response);
        }
    }
}

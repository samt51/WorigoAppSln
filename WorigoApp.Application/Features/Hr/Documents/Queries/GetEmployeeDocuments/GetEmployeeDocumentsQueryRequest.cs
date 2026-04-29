using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments
{
    public class GetEmployeeDocumentsQueryRequest : IRequest<ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>>
    {
        public int EmployeeId { get; set; }
    }
}

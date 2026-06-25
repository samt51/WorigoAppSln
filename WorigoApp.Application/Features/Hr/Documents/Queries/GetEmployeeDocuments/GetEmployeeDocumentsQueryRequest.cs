using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments
{
/// <summary>
/// GetEmployeeDocumentsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetEmployeeDocumentsQueryRequest : IRequest<ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>>
    {
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
    }
}

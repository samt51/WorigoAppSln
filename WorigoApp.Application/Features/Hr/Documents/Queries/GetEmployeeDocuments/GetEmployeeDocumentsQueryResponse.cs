using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments
{
/// <summary>
/// GetEmployeeDocumentsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetEmployeeDocumentsQueryResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// DocumentType değerini alır veya ayarlar.
/// </summary>
public DocumentTypeEnum DocumentType { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// FileUrl değerini alır veya ayarlar.
/// </summary>
public string FileUrl { get; set; } = string.Empty;
/// <summary>
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
/// <summary>
/// IsMandatory değerini alır veya ayarlar.
/// </summary>
public bool IsMandatory { get; set; }
    }
}

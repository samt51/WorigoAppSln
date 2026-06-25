using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Documents.Commands.CreateEmployeeDocument
{
/// <summary>
/// CreateEmployeeDocumentCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateEmployeeDocumentCommandRequest : IRequest<ResponseDto<CreateEmployeeDocumentCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; set; }
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
/// DocumentNumber değerini alır veya ayarlar.
/// </summary>
public string? DocumentNumber { get; set; }
/// <summary>
/// IssuedAt değerini alır veya ayarlar.
/// </summary>
public DateTime? IssuedAt { get; set; }
/// <summary>
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
/// <summary>
/// IsMandatory değerini alır veya ayarlar.
/// </summary>
public bool IsMandatory { get; set; }
/// <summary>
/// VerifiedByEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? VerifiedByEmployeeId { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}

namespace WorigoApp.Application.Features.Hr.Documents.Commands.CreateEmployeeDocument
{
/// <summary>
/// CreateEmployeeDocumentCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateEmployeeDocumentCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ExpireAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ExpireAt { get; set; }
    }
}

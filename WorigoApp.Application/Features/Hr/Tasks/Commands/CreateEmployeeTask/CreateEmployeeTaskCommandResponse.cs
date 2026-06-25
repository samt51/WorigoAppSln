namespace WorigoApp.Application.Features.Hr.Tasks.Commands.CreateEmployeeTask
{
/// <summary>
/// CreateEmployeeTaskCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateEmployeeTaskCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// DueAt değerini alır veya ayarlar.
/// </summary>
public DateTime? DueAt { get; set; }
    }
}

namespace WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus
{
/// <summary>
/// UpdateTransferStatusResponse sınıfını temsil eder.
/// </summary>
public class UpdateTransferStatusResponse
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }
}

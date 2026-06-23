namespace WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus
{
    public class UpdateTransferStatusResponse
    {
        public int GuestStayId { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}

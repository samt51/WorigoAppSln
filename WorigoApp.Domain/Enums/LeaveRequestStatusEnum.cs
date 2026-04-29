namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Izin talebinin onay surecindeki durumunu belirtir.
    /// </summary>
    public enum LeaveRequestStatusEnum
    {
        PendingManagerApproval = 1,
        PendingHrApproval = 2,
        Approved = 3,
        Rejected = 4,
        Cancelled = 5
    }
}

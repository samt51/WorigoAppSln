namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Servis talebinin yaşam döngüsündeki durumunu belirtir.
    /// </summary>
    public enum ServiceRequestStatusEnum
    {
        Open = 1,
        Assigned = 2,
        InProgress = 3,
        WaitingCustomer = 4,
        Completed = 5,
        Cancelled = 6,
        Closed = 7,
        OnTheWay = 8
    }
}

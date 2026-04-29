namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Misafir folyosuna veya online tahsilata konu olan ücret kaleminin durumunu belirtir.
    /// </summary>
    public enum ChargeStatusEnum
    {
        Pending = 1,
        PostedToRoom = 2,
        AwaitingPayment = 3,
        Paid = 4,
        Cancelled = 5,
        Refunded = 6
    }
}

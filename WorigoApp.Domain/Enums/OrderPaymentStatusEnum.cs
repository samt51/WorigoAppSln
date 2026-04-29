namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Siparişin ödeme durumunu belirtir.
    /// </summary>
    public enum OrderPaymentStatusEnum
    {
        Pending = 1,
        AwaitingOnlinePayment = 2,
        Paid = 3,
        Failed = 4,
        Refunded = 5,
        Cancelled = 6
    }
}

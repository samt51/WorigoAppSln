namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Stok talebinin surec durumunu tutar.
    /// </summary>
    public enum StockRequestStatusEnum
    {
        Pending = 1,
        Approved = 2,
        Rejected = 3,
        Fulfilled = 4,
        Cancelled = 5
    }
}

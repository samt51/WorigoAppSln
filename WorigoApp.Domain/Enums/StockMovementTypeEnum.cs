namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Stok hareketinin hangi islem tipinde oldugunu belirtir.
    /// </summary>
    public enum StockMovementTypeEnum
    {
        PurchaseIn = 1,
        UsageOut = 2,
        AdjustmentIn = 3,
        AdjustmentOut = 4,
        SaleOut = 5,
        ReturnIn = 6
    }
}

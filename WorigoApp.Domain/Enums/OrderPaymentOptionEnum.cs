namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Siparişin nasıl tahsil edileceğini belirtir.
    /// </summary>
    public enum OrderPaymentOptionEnum
    {
        IncludedInPackage = 1,
        RoomCharge = 2,
        OnlinePayment = 3,
        OnSitePayment = 4
    }
}

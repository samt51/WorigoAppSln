namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Online ödeme sırasında kullanılan sağlayıcı bilgisini tutar.
    /// </summary>
    public enum PaymentProviderEnum
    {
        Unknown = 0,
        Iyzico = 1,
        Stripe = 2,
        PayTR = 3,
        Manual = 4
    }
}

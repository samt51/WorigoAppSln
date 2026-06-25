namespace WorigoApp.Domain.Enums
{
/// <summary>
/// ValidationMessageType numaralandırma türünü temsil eder.
/// </summary>
public enum ValidationMessageType
    {
        IsNull = 1,
        MinCharacterLimit = 2,
        MaxCharacterLimit = 3,
        EmailAddressControll = 4,
        PasswordIsNull = 5,

    }
}

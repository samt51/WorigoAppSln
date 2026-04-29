namespace WorigoApp.Domain.Enums
{
    /// <summary>
    /// Misafir sohbet oturumunun yaşam döngüsü durumunu belirtir.
    /// </summary>
    public enum ConversationStatusEnum
    {
        Open = 1,
        WaitingForGuest = 2,
        WaitingForStaff = 3,
        ConvertedToServiceRequest = 4,
        Closed = 5
    }
}

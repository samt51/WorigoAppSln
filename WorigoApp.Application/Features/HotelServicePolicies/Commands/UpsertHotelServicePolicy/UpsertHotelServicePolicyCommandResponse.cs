namespace WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy
{
    public class UpsertHotelServicePolicyCommandResponse
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}

namespace WorigoApp.Application.Features.HotelServicePolicies.Commands.UpsertHotelServicePolicy
{
/// <summary>
/// UpsertHotelServicePolicyCommandResponse sınıfını temsil eder.
/// </summary>
public class UpsertHotelServicePolicyCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; } = string.Empty;
    }
}

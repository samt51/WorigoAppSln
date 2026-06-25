namespace WorigoApp.Application.Features.Auth.Dtos
{
/// <summary>
/// GenerateTokenRequest sınıfını temsil eder.
/// </summary>
public class GenerateTokenRequest
    {
/// <summary>
/// GenerateTokenRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GenerateTokenRequest(int Id, string email, string role, int roleId)
        {

            this.Id = Id;
            Email = email;
            Role = role;
            RoleId = roleId;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string Email { get; set; }
/// <summary>
/// Role değerini alır veya ayarlar.
/// </summary>
public string Role { get; set; }
/// <summary>
/// RoleId değerini alır veya ayarlar.
/// </summary>
public int RoleId { get; set; }
    }
}

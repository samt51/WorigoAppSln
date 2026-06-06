namespace WorigoApp.Application.Features.Auth.Dtos
{
    public class GenerateTokenRequest
    {
        public GenerateTokenRequest(int Id, string email, string role, int roleId)
        {

            this.Id = Id;
            Email = email;
            Role = role;
            RoleId = roleId;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
    }
}

namespace WorigoApp.Application
{
    public class GenerateTokenRequest
    {
        public GenerateTokenRequest(int Id,string email,string role)
        {
            
            this.Id = Id;
            this.Email = email;
            this.Role = role;   
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}

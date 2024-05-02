namespace WorigoApp.Application.Features.Auth.Commands.Login
{
    public class LoginCommandResponse
    {
        public string Token { get; set; }
        public DateTime TokenExpireDate { get; set; }
    }
}

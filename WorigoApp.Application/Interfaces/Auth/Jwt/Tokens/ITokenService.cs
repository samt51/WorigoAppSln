using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Interfaces.Auth.Jwt.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(Users user, IList<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
        public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest roleRequest);
    }
}

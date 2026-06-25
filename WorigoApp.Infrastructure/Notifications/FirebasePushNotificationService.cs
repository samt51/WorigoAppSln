using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using WorigoApp.Application.Interfaces.Notifications;

namespace WorigoApp.Infrastructure.Notifications
{
    /// <summary>
    /// FirebasePushNotificationService sınıfını temsil eder.
    /// </summary>
    public class FirebasePushNotificationService : IPushNotificationService
    {
        private static readonly string[] Scopes = { "https://www.googleapis.com/auth/firebase.messaging" };

        private readonly HttpClient _httpClient;
        private readonly FirebasePushNotificationSettings _settings;
        private readonly SemaphoreSlim _tokenLock = new(1, 1);
        private string? _accessToken;
        private DateTime _accessTokenExpiresAt;
/// <summary>
/// FirebasePushNotificationService sınıfının yeni bir örneğini başlatır.
/// </summary>
public FirebasePushNotificationService(HttpClient httpClient, IOptions<FirebasePushNotificationSettings> options)
        {
            _httpClient = httpClient;
            _settings = options.Value;
        }
 /// <summary>
 /// SendToDeviceAsync işlemini gerçekleştirir.
 /// </summary>

        public async Task SendToDeviceAsync(
            string deviceToken,
            string title,
            string body,
            IDictionary<string, string>? data = null,
            CancellationToken cancellationToken = default)
        {
            if (!_settings.Enabled || string.IsNullOrWhiteSpace(deviceToken) || !HasServiceAccountConfig())
            {
                return;
            }

            var accessToken = await GetAccessTokenAsync(cancellationToken);
            var requestUri = $"https://fcm.googleapis.com/v1/projects/{_settings.ProjectId}/messages:send";

            var payload = new
            {
                message = new
                {
                    token = deviceToken,
                    notification = new
                    {
                        title,
                        body
                    },
                    data = data ?? new Dictionary<string, string>(),
                    android = new
                    {
                        priority = "HIGH",
                        notification = new
                        {
                            sound = "default",
                            channel_id = _settings.AndroidChannelId
                        }
                    },
                    apns = new
                    {
                        payload = new
                        {
                            aps = new
                            {
                                sound = "default"
                            }
                        }
                    }
                }
            };

            using var httpRequest = new HttpRequestMessage(HttpMethod.Post, requestUri);
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            httpRequest.Content = JsonContent.Create(payload);

            using var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
            response.EnsureSuccessStatusCode();
        }

        private async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(_accessToken) && _accessTokenExpiresAt > DateTime.UtcNow.AddMinutes(5))
            {
                return _accessToken;
            }

            await _tokenLock.WaitAsync(cancellationToken);
            try
            {
                if (!string.IsNullOrWhiteSpace(_accessToken) && _accessTokenExpiresAt > DateTime.UtcNow.AddMinutes(5))
                {
                    return _accessToken;
                }

                var assertion = CreateJwtAssertion();
                var tokenRequest = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    ["grant_type"] = "urn:ietf:params:oauth:grant-type:jwt-bearer",
                    ["assertion"] = assertion
                });

                using var response = await _httpClient.PostAsync("https://oauth2.googleapis.com/token", tokenRequest, cancellationToken);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync(cancellationToken);
                using var document = JsonDocument.Parse(json);
                _accessToken = document.RootElement.GetProperty("access_token").GetString();
                var expiresIn = document.RootElement.GetProperty("expires_in").GetInt32();
                _accessTokenExpiresAt = DateTime.UtcNow.AddSeconds(expiresIn);

                return _accessToken!;
            }
            finally
            {
                _tokenLock.Release();
            }
        }

        private string CreateJwtAssertion()
        {
            var now = DateTimeOffset.UtcNow;
            using var rsa = RSA.Create();
            rsa.ImportFromPem(NormalizePrivateKey(_settings.PrivateKey).ToCharArray());

            var securityKey = new RsaSecurityKey(rsa);
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.RsaSha256);
            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = _settings.ClientEmail,
                Audience = "https://oauth2.googleapis.com/token",
                NotBefore = now.UtcDateTime,
                Expires = now.AddMinutes(55).UtcDateTime,
                SigningCredentials = credentials,
                Claims = new Dictionary<string, object>
                {
                    ["scope"] = string.Join(' ', Scopes),
                    [JwtRegisteredClaimNames.Iat] = now.ToUnixTimeSeconds()
                },
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, _settings.ClientEmail)
                })
            };

            return new JsonWebTokenHandler().CreateToken(descriptor);
        }

        private bool HasServiceAccountConfig()
        {
            return !string.IsNullOrWhiteSpace(_settings.ProjectId) &&
                   !string.IsNullOrWhiteSpace(_settings.ClientEmail) &&
                   !string.IsNullOrWhiteSpace(_settings.PrivateKey);
        }

        private static string NormalizePrivateKey(string privateKey)
        {
            return privateKey.Replace("\\n", "\n");
        }
    }

    /// <summary>
    /// FirebasePushNotificationSettings sınıfını temsil eder.
    /// </summary>
    public class FirebasePushNotificationSettings
    {
/// <summary>
/// Enabled değerini alır veya ayarlar.
/// </summary>
public bool Enabled { get; set; }
/// <summary>
/// ProjectId değerini alır veya ayarlar.
/// </summary>
public string ProjectId { get; set; } = string.Empty;
/// <summary>
/// ClientEmail değerini alır veya ayarlar.
/// </summary>
public string ClientEmail { get; set; } = string.Empty;
/// <summary>
/// PrivateKey değerini alır veya ayarlar.
/// </summary>
public string PrivateKey { get; set; } = string.Empty;
/// <summary>
/// AndroidChannelId değerini alır veya ayarlar.
/// </summary>
public string AndroidChannelId { get; set; } = "default";
    }
}

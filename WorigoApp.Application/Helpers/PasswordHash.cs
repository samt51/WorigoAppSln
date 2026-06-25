using System.Security.Cryptography;
using System.Text;

namespace WorigoApp.Application.Helpers
{
    /// <summary>
    /// PasswordHash sınıfını temsil eder.
    /// </summary>
    public class PasswordHash
    {
/// <summary>
/// HashPassword işlemini gerçekleştirir.
/// </summary>
public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
/// <summary>
/// VerifyPassword işlemini gerçekleştirir.
/// </summary>
public static bool VerifyPassword(string userInputPassword, string hashedPassword)
        {
            string userInputHashedPassword = HashPassword(userInputPassword);
            return userInputHashedPassword == hashedPassword;
        }
    }
}

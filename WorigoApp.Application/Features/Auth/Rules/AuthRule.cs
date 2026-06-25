using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Exceptions;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Auth.Rules
{
/// <summary>
/// AuthRule sınıfını temsil eder.
/// </summary>
public class AuthRule : BaseRules
    {
/// <summary>
/// IsThereUserForThisEmail işlemini gerçekleştirir.
/// </summary>
public Task IsThereUserForThisEmail(Users users)
        {
            if (users is not null) throw new IsThereUserForThisEmailException();
            return Task.CompletedTask;
        }
/// <summary>
/// PasswordAndConfirmPasswordToCompare işlemini gerçekleştirir.
/// </summary>
public Task PasswordAndConfirmPasswordToCompare(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword)) throw new PasswordAndConfirmPasswordToCompareException();
            return Task.CompletedTask;
        }
/// <summary>
/// EmailOrPasswordShouldNotBeInvalid işlemini gerçekleştirir.
/// </summary>
public Task EmailOrPasswordShouldNotBeInvalid(Users? user)
        {
            if (user is null) throw new EmailOrPasswordShouldNotBeInvalidException();
            return Task.CompletedTask;
        }

    }
}

using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Exceptions;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Auth.Rules
{
    public class AuthRule : BaseRules
    {
        public Task IsThereUserForThisEmail(Users users)
        {
            if (users is not null) throw new IsThereUserForThisEmailException();
            return Task.CompletedTask;
        }
        public Task PasswordAndConfirmPasswordToCompare(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword)) throw new PasswordAndConfirmPasswordToCompareException();
            return Task.CompletedTask;
        }
        public Task EmailOrPasswordShouldNotBeInvalid(Users? user)
        {
            if (user is null) throw new EmailOrPasswordShouldNotBeInvalidException();
            return Task.CompletedTask;
        }

    }
}

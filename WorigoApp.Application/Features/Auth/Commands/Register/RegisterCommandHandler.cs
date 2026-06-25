using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Auth.Rules;
using WorigoApp.Application.Helpers;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Auth.Commands.Register
{
/// <summary>
/// RegisterCommandHandler sınıfını temsil eder.
/// </summary>
public class RegisterCommandHandler : BaseHandler, IRequestHandler<RegisterCommandRequest, ResponseDto<RegisterCommandResponse>>
    {
        private readonly AuthRule _authRule;
/// <summary>
/// RegisterCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public RegisterCommandHandler(AuthRule authRule, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            this._authRule = authRule;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<RegisterCommandResponse>> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            var user = mapper.Map<Users, RegisterCommandRequest>(request);

            user.RoleId = 1;

            await _authRule.PasswordAndConfirmPasswordToCompare(request.Password, request.ConfirmPassword);

            await _authRule.IsThereUserForThisEmail(await unitOfWork.GetReadRepository<Users>().FindAsync(y => y.Email == request.Email));

            user.Password = PasswordHash.HashPassword(request.Password);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<Users>().AddAsync(user);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<RegisterCommandResponse>().Success();

        }
    }
}

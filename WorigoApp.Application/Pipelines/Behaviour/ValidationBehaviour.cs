using FluentValidation;
using FluentValidation.Results;
using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Pipelines.Behaviour
{
    /// <summary>
    /// ValidationBehaviour sınıfını temsil eder.
    /// </summary>
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, ResponseDto<List<ValidationFailure>>> where TRequest : IRequest<ResponseDto<List<ValidationFailure>>> where TResponse : ResponseDto<List<ValidationFailure>>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
/// <summary>
/// ValidationBehaviour sınıfının yeni bir örneğini başlatır.
/// </summary>
public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<List<ValidationFailure>>> Handle(TRequest request, RequestHandlerDelegate<ResponseDto<List<ValidationFailure>>> next, CancellationToken cancellationToken)
        {
            if (_validators.Any())
            {
                var context = new ValidationContext<TRequest>(request);

                var validationResults = await Task.WhenAll(
                    _validators.Select(v =>
                        v.ValidateAsync(context, cancellationToken)));

                var failures = validationResults
                    .Where(r => r.Errors.Any())
                    .SelectMany(r => r.Errors)
                    .ToList();

                if (failures.Any())
                    return await Task.FromResult<ResponseDto<List<ValidationFailure>>>((new ResponseDto<List<ValidationFailure>>().Fail(failures, "", 200)));
            }
            return await next();
        }
    }
}

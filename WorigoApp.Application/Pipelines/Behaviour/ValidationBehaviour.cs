using FluentValidation;
using FluentValidation.Results;
using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Pipelines.Behaviour
{
    public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, Response<List<ValidationFailure>>> where TRequest : IRequest<Response<List<ValidationFailure>>> where TResponse : Response<List<ValidationFailure>>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehaviour(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }



        public async Task<Response<List<ValidationFailure>>> Handle(TRequest request, RequestHandlerDelegate<Response<List<ValidationFailure>>> next, CancellationToken cancellationToken)
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
                    return await Task.FromResult<Response<List<ValidationFailure>>>((new Response<List<ValidationFailure>>().Fail(failures, "", 200)));
            }
            return await next();
        }
    }
}

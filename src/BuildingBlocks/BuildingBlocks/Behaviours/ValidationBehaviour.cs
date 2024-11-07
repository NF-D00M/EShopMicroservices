using BuildingBlocks.CQRS;
using MediatR;
using FluentValidation;

namespace BuildingBlocks.Behaviours
{
    public class ValidationBehaviour<TRequest, TResponse> 
        (IEnumerable<IValidator<TRequest>> validators)
        : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : ICommand<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);

            var validationResults = await Task.WhenAll(validators.Select(x => x.ValidateAsync(context, cancellationToken)));
        
            var failuers = 
                validationResults 
                .Where(x => x.Errors.Any())
                .SelectMany(x => x.Errors)
                .ToList();

            return await next();
        }
    }
}

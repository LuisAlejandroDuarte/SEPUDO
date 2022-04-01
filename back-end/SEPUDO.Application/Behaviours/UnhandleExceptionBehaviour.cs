using MediatR;
using Microsoft.Extensions.Logging;

namespace SEPUDO.Application.Behaviours
{
    public class UnhandleExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<TRequest> logger;

        public UnhandleExceptionBehaviour(ILogger<TRequest> logger)
        {
            this.logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {

                var requestName =typeof(TRequest).Name;
                logger.LogError(ex, "Application Request:Sucedión una excepcion para el request {Name} {@Reqeust}", requestName, request);
                throw;
            }
        }
    }
}

using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SEPUDO.Application.Behaviours;
using System.Reflection;


namespace SEPUDO.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());            
            services.AddMediatR(Assembly.GetExecutingAssembly());            
            services.AddTransient(typeof(IPipelineBehavior<,>),typeof(UnhandleExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}

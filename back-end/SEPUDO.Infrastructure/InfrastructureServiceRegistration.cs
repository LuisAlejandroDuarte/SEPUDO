using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SEPUDO.Application.Contracts.Infrastructure;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Application.Models;
using SEPUDO.Infrastructure.Email;
using SEPUDO.Infrastructure.Persistence;
using SEPUDO.Infrastructure.Repositores;


namespace SEPUDO.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<SepudoDbContext>(option =>
                option.UseSqlServer(configuration.GetConnectionString("ConnectionString"),
                b=>b.MigrationsAssembly(typeof(SepudoDbContext).Assembly.FullName))
            );
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<ISuscriptorRepository, SuscriptorRepository>();
            services.AddScoped<IUsoRepository, UsoRepository>();            
            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}

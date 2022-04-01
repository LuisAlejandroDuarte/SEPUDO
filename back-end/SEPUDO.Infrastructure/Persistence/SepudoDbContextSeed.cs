using SEPUDO.Domain.Entidades;
using Microsoft.Extensions.Logging;


namespace SEPUDO.Infrastructure.Persistence
{
    public class SepudoDbContextSeed
    {
        public static async Task SeedAsync(SepudoDbContext context,ILogger <SepudoDbContext> logger)
        {
            if (!context.Usos!.Any())
            {
                context.Usos?.AddRange(GetPreconfigureUso());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos ingresando nuevos records al db {context}", typeof(SepudoDbContext).Name);
            }
        }

        private static IEnumerable<Uso> GetPreconfigureUso()
        {
            return new List<Uso>
            {
                new Uso {CreateBy = "lduarte", Codigo = 1, Descripcion= "Uso 1", Estrato = 1 },
                new Uso {CreateBy = "lduarte", Codigo = 2, Descripcion ="Uso 2", Estrato = 2 }
            };
        }
    }
}

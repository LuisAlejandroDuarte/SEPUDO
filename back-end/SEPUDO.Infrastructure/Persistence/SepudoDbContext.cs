using Microsoft.EntityFrameworkCore;
using SEPUDO.Domain.Common;
using SEPUDO.Domain.Entidades;

namespace SEPUDO.Infrastructure.Persistence
{
    public class SepudoDbContext:DbContext
    {

        public DbSet<Uso>? Usos { get; set; }
        public DbSet<Suscriptor>? Suscriptores { get; set; }
        public DbSet<Deuda>? Deudas { get; set; }
        public DbSet<Empresa>? Empresas { get; set; }


        public  SepudoDbContext(DbContextOptions<SepudoDbContext> options):base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            foreach(var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreateBy = "system";
                        break;
                    case EntityState.Modified:      
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=CASA;
        //        Initial Catalog=SEPUDO;Integrated Security=true")
        //    .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information)
        //    .EnableSensitiveDataLogging();

        //}
    }
}

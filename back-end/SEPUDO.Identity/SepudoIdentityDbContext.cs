using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEPUDO.Identity.Configuratios;
using SEPUDO.Identity.Models;

namespace SEPUDO.Identity
{
    public class SepudoIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public SepudoIdentityDbContext(DbContextOptions<SepudoIdentityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

        }
    }
}

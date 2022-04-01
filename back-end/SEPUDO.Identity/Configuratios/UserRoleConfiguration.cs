using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SEPUDO.Identity.Configuratios
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
               builder.HasData(
                   new IdentityUserRole<string>
                   {
                       RoleId = "45b5414f-4f66-40e3-a400-bed02e9e1b30",
                       UserId = "8e684fdd-435e-4729-8d9e-962983e62e12"
                   },
                   new IdentityUserRole<string>
                   {
                       RoleId = "67fa1d4a-f729-44bc-ae9a-62d5510a338c",
                       UserId = "db801ec6-eb50-413e-b511-ee2aaf6006f1"
                   }
               );
        }
    }
}

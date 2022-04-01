using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SEPUDO.Identity.Configuratios
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id= "45b5414f-4f66-40e3-a400-bed02e9e1b30",
                    Name="Administrador",
                    NormalizedName="ADMINISTRADOR"
                },
                new IdentityRole
                {
                    Id = "bb249f50-ac6d-11ec-b909-0242ac120002",
                    Name = "Usuario",
                    NormalizedName = "Usuario"
                },
                new IdentityRole
                {
                    Id = "67fa1d4a-f729-44bc-ae9a-62d5510a338c",
                    Name = "Operario",
                    NormalizedName = "OPERARIO"
                }
            );
        }
    }
}

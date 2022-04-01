using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SEPUDO.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPUDO.Identity.Configuratios
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "8e684fdd-435e-4729-8d9e-962983e62e12",
                    Email = "ladm4@hotmail.com",
                    NormalizedEmail = "ladm4@hotmail.com",
                    Nombre = "Luis",
                    Apellidos = "Duarte",
                    UserName = "lduarte",
                    NormalizedUserName = "lduarte",
                    PasswordHash = hasher.HashPassword(null, "Lu1sAlej0"),
                    EmailConfirmed=true
                },
                new ApplicationUser
                {
                    Id = "db801ec6-eb50-413e-b511-ee2aaf6006f1",
                    Email = "carrera2wn5929@gmail.com",
                    NormalizedEmail = "carrera2wn5929@gmail.com",
                    Nombre = "Alejandro",
                    Apellidos = "Martinez",
                    UserName = "amartinez",
                    NormalizedUserName = "amartinez",
                    PasswordHash = hasher.HashPassword(null, "Lu1sAlej0"),
                    EmailConfirmed = true
                }
              );
        }
    }
}

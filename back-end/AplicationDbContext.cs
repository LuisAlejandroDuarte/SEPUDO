using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Entidades;
using Microsoft.EntityFrameworkCore;

namespace back_end
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Uso> Uso { get; set; }
        public DbSet<Suscriptor> Suscriptor { get; set; }
        public DbSet<Lectura> Lectura { get; set; }
        public DbSet<Consumo> Consumo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }


    }
}

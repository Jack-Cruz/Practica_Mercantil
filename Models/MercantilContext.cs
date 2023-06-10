using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Practica_Mercantil.Models
{
    public class MercantilContext : DbContext
    {

        public MercantilContext (DbContextOptions<MercantilContext> options)
            : base(options)
        {
        }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trabajador>().ToTable("Trabajador");
            modelBuilder.Entity<Distrito>().ToTable("Distrito");
            modelBuilder.Entity<Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Departamento>().ToTable("Trabajador");

        }
        
  


    }
}

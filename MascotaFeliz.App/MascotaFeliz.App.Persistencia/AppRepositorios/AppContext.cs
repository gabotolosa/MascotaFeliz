using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Dueno> Duenos {get;set;}
        public DbSet<VisitaPyP> VisitasPyP {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = MascolaFelizData.mssql.somee.com; Initial Catalog = MascolaFelizData; user id=Ktorres_SQLLogin_1; pwd=l4jvk99z5j");
            }
        }
    }
}
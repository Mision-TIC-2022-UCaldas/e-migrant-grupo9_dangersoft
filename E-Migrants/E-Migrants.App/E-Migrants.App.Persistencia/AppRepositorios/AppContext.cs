// using System.Collections;
// using System.Reflection;
// using System.Runtime.CompilerServices;
using E_Migrants.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

// using E_Migrants.App.Persistencia.AppRepositorios;

namespace E_Migrants.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Migrante> Migrante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= DangerSoftDB");
            }
        }
    }
}
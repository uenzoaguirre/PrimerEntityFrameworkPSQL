using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ej1
{
    class AgendaContext : DbContext {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Telefono> Telefonos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=ej1t;Username=admin;Password=admin");
    }    
}
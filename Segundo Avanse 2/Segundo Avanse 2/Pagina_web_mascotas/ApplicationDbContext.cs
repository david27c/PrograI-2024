using Microsoft.EntityFrameworkCore;
using System;

namespace Segundo_Avanse_2.Pagina_web_mascotas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Colecciones de entidades
        public DbSet<mascota> Mascotas { get; set; }
        public DbSet<refugio> Refugios { get; set; }
        public DbSet<Solicitudadopcion> SolicitudesAdopcion { get; set; }
    }
    
}



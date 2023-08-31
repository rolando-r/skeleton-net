using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class DbEjContext : DbContext
    {
        public DbEjContext(DbContextOptions<DbEjContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        //

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
using System.Reflection;
using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class DbEjContext : DbContext
    {
        public DbEjContext(DbContextOptions<DbEjContext> options) : base(options)
        {
        }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
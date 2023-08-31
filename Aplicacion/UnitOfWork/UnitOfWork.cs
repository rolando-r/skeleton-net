using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;
namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbEjContext context;
        private RolRepository _roles;
        private IUsuarioRepository _usuarios;
        public UnitOfWork(DbEjContext _context)
        {
            context = _context;
        }
        public IRolRepository Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(context);
                }
                return _roles;
            }
        }
        public IUsuarioRepository Usuarios
        {
            get
            {
                if (_usuarios == null)
                {
                    _usuarios = new UsuarioRepository(context);
                }
                return _usuarios;
            }
        }
        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
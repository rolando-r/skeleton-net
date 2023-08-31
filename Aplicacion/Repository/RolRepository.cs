using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class RolRepository : GenericRepositoryB<Rol>, IRolRepository
    {
        public RolRepository(DbEjContext context) : base(context)
        {
        }
    }
}
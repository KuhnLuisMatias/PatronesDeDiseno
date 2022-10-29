using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class RepositorioClienteProxy : IRepository
    {
        IRepository _real;

        public void Guardar(Cliente cliente)
        {
            if (_real is null) _real = new RepositorioCliente();

            if (!Session.puedeGuardar)
                throw new UnauthorizedAccessException();
            
            _real.Guardar(cliente);
        }

        public IList<Cliente> ObtenerTodos()
        {
            if (_real is null) new RepositorioCliente();

            if (!Session.puedeObtenerTodos)
                throw new UnauthorizedAccessException();

            return _real.ObtenerTodos();
        }
    }
}

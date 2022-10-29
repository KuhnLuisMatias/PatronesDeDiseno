using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class RepositorioCliente : IRepository
    {
        IList<Cliente> _listaClientes;
        
        public RepositorioCliente()
        {
            _listaClientes = new List<Cliente>();
        }

        public void Guardar(Cliente cliente)
        {
            _listaClientes.Add(cliente);
        }
        public IList<Cliente> ObtenerTodos()
        {
            return _listaClientes;
        }
    }
}

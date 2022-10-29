using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repositorio = new RepositorioClienteProxy();
                Session.puedeGuardar = true;
                Session.puedeObtenerTodos = true;

                Cliente cliente_I = new Cliente("Luis Matias Kühn");
                Cliente cliente_II = new Cliente("Maria Barbara Ledezma");

                repositorio.Guardar(cliente_I);
                repositorio.Guardar(cliente_II);

                foreach (var cliente in repositorio.ObtenerTodos())
                {
                    Console.WriteLine($"{cliente.Nombre}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

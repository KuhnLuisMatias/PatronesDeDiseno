using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();
            var producto = new ProductoReceiver();
            producto.Cantidad = 100;

            var ordenAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenAlta);

            var ordenBaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenBaja);

            empresa.ProcesarOrdenes();

            Console.WriteLine("Total de stock es de : {0}", producto.Cantidad);
            Console.ReadKey();

        }
    }
}

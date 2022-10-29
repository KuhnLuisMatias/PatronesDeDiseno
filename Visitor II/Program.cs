using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productoClaseI = new ProductoClase_I();
            var productoClaseII = new ProductoClase_II();
            var productoClaseIII = new ProductoClase_III();

            var iva = new IVA();

            productoClaseI.Precio = 100;
            productoClaseII.Precio = 100;
            productoClaseIII.Precio = 100;

            Console.WriteLine(String.Format("El total para el {0} es {1}", productoClaseI.GetType().Name, productoClaseI.Aceptar(iva)));
            Console.WriteLine(String.Format("El total para el {0} es {1}", productoClaseII.GetType().Name, productoClaseII.Aceptar(iva)));
            Console.WriteLine(string.Format("El total para el {0} es {1}", productoClaseIII.GetType().Name,productoClaseIII.Aceptar(iva)));

            Console.ReadKey();
        }
    }
}

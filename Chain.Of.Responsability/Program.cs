using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            DirectorGeneral directorGeneral = new DirectorGeneral();
            Comprador comprador = new Comprador();

            Compra compra = new Compra();
            compra.importe = 1000;

            comprador.AgregarSiguiente(director);
            director.AgregarSiguiente(directorGeneral);

            comprador.Procesar(compra);

            Console.ReadLine();
        }
    }
}

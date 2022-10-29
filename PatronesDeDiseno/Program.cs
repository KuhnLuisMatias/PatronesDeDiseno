using PatronesDeDiseno.Patron_Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AbstractFactory
            Pizzeria fabrica = new PizzeriaArgentina();

            Pizza pizza = fabrica.crearPizza();

            Console.WriteLine(pizza.Descripcion);

            #endregion

            Console.ReadLine();

        }
    }
}

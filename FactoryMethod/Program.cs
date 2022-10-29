using PatronesDeDiseno.Patron_Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            Pizzeria pizzeria = new PizzeriaArgentina();
            
            pizza = pizzeria.crearPizza(1);
            pizza.Render();

            Console.ReadLine();
        }
    }
}

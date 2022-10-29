using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Patron_Abstract_Factory
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza crearPizza(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    return new PizzaNapolitana();
                case 2:
                    return new PizzaAnchoas();
                default:
                    return null;
            }
            
        }
    }
}

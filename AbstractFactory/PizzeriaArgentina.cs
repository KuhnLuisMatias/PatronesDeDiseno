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
        public override Pizza crearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}

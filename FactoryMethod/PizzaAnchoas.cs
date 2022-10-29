using PatronesDeDiseno.Patron_Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaAnchoas : Pizza
    {
        public PizzaAnchoas()
        {
            _descripcion = "Creaste una pizza Napolitana";
            _origen = "Argentina";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Patron_Abstract_Factory
{
    public abstract class Pizza
    {
        protected string _descripcion;
        
        public Object Descripcion
        {
            get { return _descripcion; }
        }
    }
}

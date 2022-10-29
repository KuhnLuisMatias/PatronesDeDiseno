using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }

    }

    public class Tomate : Salsa
    {
        public Tomate()
        {
            _descripcion = "de tomate";
        }
    }
}

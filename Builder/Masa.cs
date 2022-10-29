using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Masa
    {
        protected string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }

        }

        public class ALaPiedra : Masa
        {
            public ALaPiedra()
            {
                _descripcion = "A la piedra";
            }
        }
    }
}
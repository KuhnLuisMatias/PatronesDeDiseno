using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        Masa _masa;
        Salsa _salsa;        

        public Pizza(Masa masa, Salsa salsa)
        {
            this._masa = masa;
            this._salsa = salsa;            
        }

        public override string ToString()
        {
            return String.Format("Pizza con _masa {0} y con _salsa {1}",_masa.Descripcion,_salsa.Descripcion);
        }
    }
}

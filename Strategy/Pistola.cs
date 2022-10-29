using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Pistola : Arma
    {
        public override string Disparar()
        {
            return String.Format("Se a efectuado un disparo con una: {0}",ToString());
        }
    }
}

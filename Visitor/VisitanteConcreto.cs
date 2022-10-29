using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class VisitanteConcreto : Ivisitor
    {
        public void visitar(string serie)
        {
            Console.WriteLine("N/S: {0}",serie);
        }
    }

    internal class VisitanteConcreto2 : Ivisitor
    {
        public void visitar(string serie)
        {
            Console.WriteLine("Numero de serie: {0}",serie);
        }
    }
}

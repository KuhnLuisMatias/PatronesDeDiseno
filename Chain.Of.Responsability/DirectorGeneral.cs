using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class DirectorGeneral : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine(string.Format("El encargado de manejar esta compra es {0}",String.Format(this.GetType().Name)));
        }
    }
}

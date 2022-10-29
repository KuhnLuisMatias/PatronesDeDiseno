using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class Director : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if(c.importe < 5000)
                Console.WriteLine(String.Format("Compra tomada por {0}",this.GetType().Name));
            else
                _siguiente.Procesar(c);
        }
    }
}

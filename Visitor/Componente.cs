using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal abstract class Componente
    {
        string _serial;

        public Componente(string serial)
        {
            _serial = serial;
        }   

        public string Serial { get { return _serial; } }

        public void Aceptar(Ivisitor ivisitor)
        {
            ivisitor.visitar(Serial);
        }
    }
}

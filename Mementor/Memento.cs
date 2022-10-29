using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mementor
{
    
    internal class Memento
    {
        private string _nombre;

        public Memento() { }

        public Memento(string nombre)
        {
            _nombre = nombre;   
        }

        public string Nombre
        {
            get { return _nombre; }
        }
    }
}

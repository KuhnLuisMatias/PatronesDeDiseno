using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class Cliente
    {
        private string _nombre;
        public Cliente(string nombre)
        {
            _nombre = nombre;
        }
        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; } 
        }
    }
}

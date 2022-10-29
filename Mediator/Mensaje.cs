using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Mensaje
    {
        private DateTime _fecha;

        public Mensaje()
        {
            _fecha = DateTime.Now;
        }

        public Usuario Origen { get; set; }
        public Usuario Destino { get; set; }
        public string Texto { get; set; }

        public DateTime Fecha { get { return _fecha; } } 

        public override string ToString()
        {
            return $"{Origen} [{Fecha}] : {Texto} "; //. Enviado para {Destino}
        }
    }
}

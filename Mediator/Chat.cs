using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal abstract class Chat
    {
        protected List<Mensaje> _mensajes;
        public Chat()
        {
            _mensajes = new List<Mensaje>();
        }
        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }
        public abstract void Enviar(string mensaje, Usuario origen, Usuario destino);
        public abstract void Registrar(Usuario usuario);
    }
}

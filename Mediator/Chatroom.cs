using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Chatroom : Chat
    {
        IDictionary<string, Usuario> _participantes;
        public Chatroom()
        {
            _participantes = new Dictionary<string, Usuario>();
        }
        public override void Enviar(string texto, Usuario origen, Usuario destino)
        {
            Mensaje msg = new Mensaje();
            msg.Origen = origen;
            msg.Destino = destino;
            msg.Texto = texto;

            if (_participantes.ContainsKey(destino.Nombre))
            {
                _participantes[destino.Nombre].Recibir(msg);
                _mensajes.Add(msg);
            }

        }
        public override void Registrar(Usuario usuario)
        {
            if (!_participantes.ContainsKey(usuario.Nombre))
                _participantes.Add(usuario.Nombre, usuario);
        }
    }
}

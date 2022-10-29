using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            Chat _chat;
            Usuario usuario;
            Usuario usuarioII;

            _chat = new Chatroom();
            usuario = new Usuario("Luis Matias Kühn");
            usuarioII = new Usuario("Maria Barbara Ledezma");

            _chat.Registrar(usuario);
            _chat.Registrar(usuarioII);

            EnviarMensaje(usuario,usuarioII);
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesDelChat();
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesUsuario(usuario);
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesUsuario(usuarioII);

            Console.WriteLine("-------------------------------------------");
            EnviarMensaje(usuarioII, usuario);
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesDelChat();
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesUsuario(usuario);
            Console.WriteLine("-------------------------------------------");
            ImprimirMensajesUsuario(usuarioII);

            void EnviarMensaje(Usuario origen,Usuario destino)
            {
                Console.WriteLine($"escriba su mensaje: ");
                var msg = Console.ReadLine();
                _chat.Enviar(msg, origen,destino);
            }

            void ImprimirMensajesDelChat()
            {
                Mensaje[] listaMensajes = _chat.Mensajes;
                foreach (var msg in listaMensajes)
                {
                    Console.WriteLine(msg);
                }
            }

            void ImprimirMensajesUsuario(Usuario usr)
            {                
                Console.WriteLine(String.Format("\n Estos son los mensajes para el usuario {0}",usr.Nombre));
                Console.WriteLine("\n");
                var listaMensajes = usr.Mensajes;
                foreach(var msg in listaMensajes)
                {
                    Console.WriteLine(msg);
                }
            }

            Console.ReadKey();
        }        

    }
}

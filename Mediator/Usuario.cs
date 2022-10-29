using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Usuario
    {
        private List<Mensaje> _mensajes;
        private string _nombre;
        
        public Usuario(string nombre)
        {
            _nombre = nombre;
            _mensajes = new List<Mensaje>();
        }
        public Chat Chat { get; set; }
        public Mensaje[] Mensajes
        {
            get { return _mensajes.ToArray(); }
        }
        public string Nombre 
        { 
            get { return _nombre; } 
        }
        

        public void Enviar(string mensaje,Usuario destino)
        {
            Chat.Enviar(mensaje,origen:this, destino);
        }
        public void Recibir(Mensaje mensaje)
        {
            _mensajes.Add(mensaje);
        }
        public override string ToString()
        {
            return _nombre;
        }
    }
}

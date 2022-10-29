using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    internal class SessionManager
    {
        private static SessionManager _session;
        public Usuario usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public SessionManager() { }

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null)
                    throw new Exception("Sesión no iniciada");
                return _session;
            }
        }

        public static void LogIn(Usuario usuario)
        {
            if(_session == null)
            { 
                _session = new SessionManager();
                _session.usuario = usuario;
                _session.FechaInicio = DateTime.Now;
            }
            else
            {
                throw new Exception("Sesión ya iniciada");
            }
        }

        public static void LogOut()
        {
            if (_session != null)
                _session = null;
            else
                throw new Exception("Sesión no inciada");
        }
    }
}

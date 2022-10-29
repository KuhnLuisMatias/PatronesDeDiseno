using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Jugador
    {
        public String Nombre { get; set; }

        private Arma _estrategia;

        public void CambiarEstrategia(Arma estrategia)
        {
            if (estrategia != null)
                _estrategia = estrategia;
            else
                throw new Exception("La estrategia de disparo no puede ser nulo");
        }

        public string Disparar()
        {
            if (_estrategia == null)
                return "Arma no disponible";
            return _estrategia.Disparar();
        }
    }
}

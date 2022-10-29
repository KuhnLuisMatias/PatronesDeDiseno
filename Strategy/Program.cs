using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Arma> _estrategiasDisparo = new List<Arma>();
            _estrategiasDisparo.Add(new Pistola());

            Jugador jugador = new Jugador();
            jugador.Nombre = "Matias";

            var arma = (from a in _estrategiasDisparo select a).FirstOrDefault();
            
            jugador.CambiarEstrategia(arma);
            Console.WriteLine(String.Format("El Jugador: {0} , {1}",jugador.Nombre,jugador.Disparar())); 

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ivisitor _visitante = new VisitanteConcreto();
            Componente _componente = new DiscoRigido("ABC-123");
            _componente.Aceptar(_visitante);

            Ivisitor _visitante2 = new VisitanteConcreto2();
            Componente _componente2 = new DiscoRigido("ABC-123");
            _componente2.Aceptar(_visitante2);

            Console.ReadKey();
        }
    }
}

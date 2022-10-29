using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "2008";
            fiatPalio.Color = "Negro";

            Console.WriteLine(fiatPalio.VerAuto());


            Console.ReadLine();
        }
    }
}

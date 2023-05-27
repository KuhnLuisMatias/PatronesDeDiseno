using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First first = new First();
            Second second = new Second();
            Third Third = new Third();

            Purchase purchase = new Purchase();
            purchase.Amount = 5001;

            first.AddNextHandler(second);
            second.AddNextHandler(Third);

            first.Process(purchase);

            Console.ReadLine();
        }
    }
}

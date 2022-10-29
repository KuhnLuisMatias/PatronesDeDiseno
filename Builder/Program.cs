using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PizzaBuilder builder = new PizzaNapolitanaBuilder();

            Pizza pizza = builder.BuildPizza();

            Console.WriteLine(pizza.ToString()); 

            Console.ReadLine();
        }
    }
}

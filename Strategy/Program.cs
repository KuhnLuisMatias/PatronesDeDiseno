using Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             ES:
                El patrón de diseño Strategy se utiliza cuando necesitamos cambiar dinámicamente el algoritmo 
                o la estrategia utilizada por un objeto en tiempo de ejecución. 
                Permite encapsular diferentes algoritmos en clases separadas y permite que el objeto cambie de estrategia sin modificar su estructura.

            EN:
                The Strategy design pattern is used when we need to dynamically change the algorithm or strategy used by an object at runtime. 
                or strategy used by an object at runtime. 
                It allows encapsulating different algorithms in separate classes and allows the object to change strategy without modifying its structure.
            */

            Console.WriteLine("Please Select Payment Type : [1] For CreditCard [2] For DebitCard \n");

            int SelectedPaymentType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter Amount to Pay :\n");
            double amount = Convert.ToDouble(Console.ReadLine());

            var context = new Payment();

            switch(SelectedPaymentType)
            {
                case (int)  PaymentType.CreditCard:
                    context.SetPaymentStrategy(new CreditCard());
                    break;

                case (int)  PaymentType.DebitCard:
                    context.SetPaymentStrategy(new DebitCard());
                    break;
                
                default: Console.WriteLine("You Select an Invalid Option");
                    break;
            }
            
            //Finally, call the Pay Method
            context.Pay(amount);

            Console.ReadLine();
        }
    }
}
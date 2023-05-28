using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    public class CreditCard : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("\nCustomer pays $" + amount + " using Credit Card");
        }
    }
}

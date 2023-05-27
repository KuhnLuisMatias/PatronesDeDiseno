using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class Second : Handler
    {
        public override void Process(Purchase purchase)
        {
            if(purchase.Amount < 10000 && purchase.Amount > 5000)
                Console.WriteLine(String.Format("Purchase taked by {0}",this.GetType().Name));
            else
                _handler.Process(purchase);
        }
    }
}

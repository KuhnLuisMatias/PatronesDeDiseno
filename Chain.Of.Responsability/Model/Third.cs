using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain.Of.Responsability
{
    internal class Third : Handler
    {
        public override void Process(Purchase purchase)
        {
            Console.WriteLine(string.Format("Purchase taked by {0}",String.Format(this.GetType().Name)));
        }
    }
}

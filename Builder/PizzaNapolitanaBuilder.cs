using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Masa;

namespace Builder
{
    public class PizzaNapolitanaBuilder : PizzaBuilder
    {
        public override Masa BuildMasa()
        {
            return new ALaPiedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}

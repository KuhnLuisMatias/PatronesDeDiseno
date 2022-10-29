using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();
        protected string _descripcion;

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            return new Pizza(masa, salsa);
        }

        public override string ToString()
        {
            return _descripcion;
        }
    }
}

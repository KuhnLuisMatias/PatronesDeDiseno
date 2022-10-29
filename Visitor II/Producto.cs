using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_II
{
    internal abstract class Producto : IVisitable
    {
        public double Precio { get; set; }
        public abstract double Aceptar(IVisitor visitor);
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_II
{
    internal class IVA : IVisitor
    {
        private double impuestoClase_I = 1.21d;
        private double impuestoClase_II = 1.105d;
        public double Visitar(ProductoClase_I producto)
        {
            return producto.Precio * impuestoClase_I;
        }

        public double Visitar(ProductoClase_II producto)
        {
            return producto.Precio * impuestoClase_II;
        }

        public double Visitar(ProductoClase_III producto)
        {
            return producto.Precio * 0.5;
        }
    }
}

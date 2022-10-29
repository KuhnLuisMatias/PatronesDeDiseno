using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_II
{
    internal interface IVisitor
    {
        double Visitar(ProductoClase_I producto);
        double Visitar(ProductoClase_II producto);
        double Visitar(ProductoClase_III producto);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_II
{
    internal interface IVisitable
    {
        double Aceptar(IVisitor visitor);
    }
}

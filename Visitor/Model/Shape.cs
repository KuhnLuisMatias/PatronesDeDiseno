using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.Model
{
    public abstract class Shape
    {
        public abstract void Accept(IVisitor visitor);
    }
}

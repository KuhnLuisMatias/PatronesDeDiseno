using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.Model
{
    public class Circle : Shape
    {
        public Double Radious { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.CicleVisitor(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.Model
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override void Accept(IVisitor visitor)
        {
            visitor.TriangleVisitor(this);
        }
    }
}

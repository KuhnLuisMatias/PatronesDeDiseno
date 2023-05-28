using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model;

namespace Visitor.Interface
{
    public interface IVisitor
    {
        void CicleVisitor(Circle circle);
        void RectangleVisitor(Rectangle rectangle);
        void TriangleVisitor(Triangle triangle);
    }
}

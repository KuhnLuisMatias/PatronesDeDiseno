using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interface;

namespace Visitor.Model
{
    public class AreaCalculatorVisitor : IVisitor
    {
        public void CicleVisitor(Circle circle)
        {
            var area = Math.PI * Math.Pow(circle.Radious, 2);
            Console.WriteLine($"Circle \n\tRadious= {circle.Radious},   AREA= {Math.Round(area,2)}");
        }

        public void RectangleVisitor(Rectangle rectangle)
        {
            var area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Rectangle \n\tWidth= {rectangle.Width}, Height= {rectangle.Height}, AREA=  {area}");
        }

        public void TriangleVisitor(Triangle triangle)
        {
            var area = (triangle.Base * triangle.Height) / 2;
            Console.WriteLine($"Triangle \n\tBase= {triangle.Base}, Height= {triangle.Height},  AREA={area}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ES: 
                El patrón de diseño Visitor se utiliza cuando necesitamos realizar operaciones en una estructura de objetos compleja,
                pero queremos mantener esas operaciones separadas de las clases de los objetos en sí. 
                El patrón Visitor permite agregar nuevas operaciones sin modificar las clases existentes, 
                lo que hace que el código sea más flexible y extensible. 

            EN:
                The Visitor design pattern is used when we need to perform operations on a complex object structure,
                but we want to keep those operations separate from the object classes themselves. 
                The Visitor pattern allows adding new operations without modifying existing classes, 
                which makes the code more flexible and extensible. 
             */

            #region Circle
            var circle = new Circle() { Radious = 4 };
            var areaCalculator = new AreaCalculatorVisitor();
            circle.Accept(areaCalculator);
            #endregion

            #region Rectangle
            var rectangle = new Rectangle() { Width = 2, Height = 5 };
            rectangle.Accept(areaCalculator);
            #endregion

            #region Triangle
            var triangle = new Triangle() { Base = 2, Height = 5 };
            triangle.Accept(areaCalculator);
            #endregion

            Console.ReadLine();
        }
    }
}

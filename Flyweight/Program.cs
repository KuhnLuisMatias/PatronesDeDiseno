using Flyweight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            ES:

            Patrón de diseño Flyweight (Flyweight Design Pattern):

            El patrón de diseño Flyweight se utiliza para minimizar el uso de memoria o almacenamiento al compartir de manera eficiente objetos que son utilizados repetidamente. 
            Este patrón se basa en la idea de dividir los objetos en dos partes: la parte intrínseca, que contiene los datos compartidos y no cambiantes, y la parte extrínseca, que contiene los datos específicos y cambiantes.

            Flyweight:  
                Define la interfaz común para los objetos flyweight y especifica los métodos para obtener y manipular los datos extrínsecos.

            FlyweightFactory: 
                Es responsable de crear y administrar los objetos flyweight. 
                Mantiene un pool de objetos flyweight existentes y reutiliza los objetos existentes cuando es posible, en lugar de crear nuevos objetos.

            Cliente: 
                Utiliza los objetos flyweight a través del FlyweightFactory. 
                Puede proporcionar los datos extrínsecos necesarios para la operación de los objetos flyweight.

            El patrón Flyweight permite reducir el uso de memoria al compartir objetos y almacenar datos compartidos en un lugar centralizado. 
            Esto es especialmente útil cuando se trabaja con un gran número de objetos similares, 
            ya que se puede lograr una eficiencia significativa al reutilizar objetos existentes en lugar de crear nuevos objetos.

            EN:

            Flyweight Design Pattern (Patrón de diseño Flyweight):

            The Flyweight design pattern is used to minimize memory or storage usage by efficiently sharing objects that are used repeatedly. This pattern is based on the idea of dividing objects into two parts: the intrinsic part, which contains the shared and unchanging data, and the extrinsic part, which contains the specific and changing data.

            Flyweight: Defines the common interface for flyweight objects and specifies methods for obtaining and manipulating extrinsic data.

            FlyweightFactory: Is responsible for creating and managing flyweight objects. It maintains a pool of existing flyweight objects and reuses existing objects when possible, instead of creating new ones.

            Client: Uses flyweight objects through the FlyweightFactory. It can provide the necessary extrinsic data for the operation of flyweight objects.

            The Flyweight pattern allows reducing memory usage by sharing objects and storing shared data in a centralized place. This is especially useful when working with a large number of similar objects, as significant efficiency can be achieved by reusing existing objects instead of creating new ones.
            */

            Action<string> drawCircles = (color) =>
            {
                Console.WriteLine($"\n {color} color Circles");
                for (int i = 0; i < 3; i++)
                {
                    Circle circle = (Circle)ShapeFactory.GetShape("circle");
                    circle.SetColor(color);
                    circle.Draw();
                }
            };

            drawCircles("Red");
            drawCircles("Green");
            drawCircles("Blue");
            drawCircles("Orange");
            drawCircles("Black");

            Console.ReadKey();
        }
    }
}

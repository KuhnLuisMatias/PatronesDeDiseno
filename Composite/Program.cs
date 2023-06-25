using Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            
                Patrón de diseño Composite (Composite Design Pattern):

                El patrón de diseño Composite se utiliza para representar una estructura jerárquica de objetos en forma de árbol. 
                Este patrón permite tratar tanto a los objetos individuales como a las agrupaciones de objetos de manera uniforme, ya que siguen una interfaz común.

                Componente (Component): 
                    Define la interfaz común para todos los objetos en la estructura. 
                    Puede representar tanto objetos individuales como agrupaciones de objetos.

                Hoja (Leaf): 
                    Representa los objetos individuales en la estructura. 
                    No tienen hijos y suelen ser los elementos más básicos de la jerarquía.

                Compuesto (Composite): 
                    Representa las agrupaciones de objetos en la estructura. 
                    Almacena una lista de componentes hijos y puede realizar operaciones en conjunto con ellos.

                El patrón Composite permite tratar a los objetos individuales y a las agrupaciones de objetos de manera uniforme, 
                ya que ambos implementan la misma interfaz. 
                Esto facilita la manipulación de la estructura jerárquica de manera recursiva, 
                ya que se pueden aplicar operaciones a todos los elementos de la estructura sin tener que distinguir entre objetos individuales y agrupaciones.

                Composite Design Pattern:

                The Composite design pattern is used to represent a hierarchical structure of objects in the form of a tree. 
                This pattern allows treating both individual objects and groups of objects in a uniform way, as they follow a common interface.

                Component: 
                    Defines the common interface for all objects in the structure. 
                    It can represent both individual objects and groups of objects.

                Leaf: 
                    Represents the individual objects in the structure. 
                    They have no children and are usually the basic elements of the hierarchy.

                Composite: 
                    Represents the groups of objects in the structure. 
                    It stores a list of child components and can perform operations collectively with them.

                The Composite pattern allows treating individual objects and groups of objects in a uniform way, 
                as they both implement the same interface. 
                This facilitates the manipulation of the hierarchical structure recursively, 
                as operations can be applied to all elements of the structure without having to distinguish between individual objects and groups.
            */

            var hardDisk = new Leaf("Hard Disk", 2000);
            var ram = new Leaf("RAM", 3000);
            var cpu = new Leaf("CPU", 2000);
            var mouse = new Leaf("Mouse", 2000);
            var keyboard = new Leaf("Keyboard", 2000);

            //Creating Composite Objects
            var motherBoard = new CompositeClass("MotherBoard");
            var cabinet = new CompositeClass("Cabinet");
            var peripherals = new CompositeClass("Peripherals");
            var computer = new CompositeClass("Computer");
            
            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            
            //Adding Mother Board and Hard Disk in Cabinet
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            
            //Adding Mouse and Keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            
            //Adding Cabinet and Peripherals in Computer
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            
            //To Display the Price of the Computer i.e. it will display the Price of all components
            Console.WriteLine("Price of Computer Composite Components");
            computer.DisplayPrice();
            
            //To display the Price of the Keyboard
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();

            //To display the Price of the Cabinet
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();
            
            Console.Read();
        }
    }
}

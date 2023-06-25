using Facade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            
            ES:
            
            Según la definición del GOF, el patrón de diseño de fachada establece que es necesario proporcionar una interfaz unificada a un conjunto de interfaces en un subsistema. 
            El patrón de diseño de fachada define una interfaz de nivel superior que facilita el uso del subsistema.
            En palabras sencillas, podemos decir que el patrón de diseño Facade se utiliza para ocultar las complejidades de un sistema y proporciona una interfaz fácil de usar al cliente mediante la cual éste puede acceder al sistema. 
            La clase Facade (normalmente un wrapper) se sitúa en la parte superior de un grupo de subsistemas y les permite comunicarse de forma unificada.

            Necesitamos utilizar el patrón de diseño Facade en C# cuando un sistema es muy complejo o muy difícil de entender. 
            Esto se debe a que el sistema tiene un gran número de clases interdependientes.

            Como su nombre indica, Facade significa la Cara del Edificio. 
            Supongamos que has creado un edificio. La gente que camina fuera del edificio sólo puede ver las paredes y el cristal del Edificio. 
            La gente no sabe nada sobre el cableado, las tuberías, los interiores, y otras complejidades que hay dentro del edificio.
            Eso significa que la fachada oculta todas las complejidades del edificio y muestra una cara amable a la gente que camina fuera del edificio.

            EN:

            As defined by the GOF, the facade design pattern states that it is necessary to provide a unified interface to a set of interfaces in a subsystem. 
            The Facade design pattern defines a top-level interface that facilitates the use of the subsystem.
            In simple words, we can say that the Facade design pattern is used to hide the complexities of a system and provides a user-friendly interface to the client through which the client can access the system. 
            The Facade class (usually a wrapper) sits on top of a group of subsystems and allows them to communicate in a unified way.

            We need to use the Facade design pattern in C# when a system is very complex or very difficult to understand. 
            This is because the system has a large number of interdependent classes.

            As the name implies, Facade means the Face of the Building. 
            Suppose you have created a building. People walking outside the building can only see the walls and glass of the Building. 
            People know nothing about the wiring, plumbing, interiors, and other intricacies inside the building.
            That means that the facade hides all the complexities of the building and shows a friendly face to people walking outside the building.
            */

            var order = new Order();
            order.PlaceOrder();

            Console.Read();
        }
    }
}

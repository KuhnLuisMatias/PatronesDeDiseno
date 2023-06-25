using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Model;

namespace TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*ES:

            El patrón de diseño Template Method (Método de Plantilla) es un patrón de comportamiento que define la estructura básica de un algoritmo en una clase base, 
            dejando que las subclases implementen ciertos pasos o detalles específicos del algoritmo. 
            El patrón se basa en el principio de inversión de dependencia y promueve el reuso del código al permitir que las subclases proporcionen implementaciones personalizadas de partes específicas del algoritmo sin cambiar la estructura general.

            En resumen, el patrón de diseño Template Method permite definir un esqueleto de algoritmo en una clase base y delegar la implementación de pasos concretos a las subclases. 
            Esto proporciona flexibilidad y extensibilidad al permitir que las subclases personalicen partes del algoritmo según sea necesario.

            Beneficios del patrón de diseño Template Method:

            a.  Promueve el reuso del código al definir una estructura general en una clase base y permitir que las subclases implementen detalles específicos.
            b.  Permite la extensión del algoritmo sin cambiar su estructura básica.
            c.  Proporciona un punto de extensión claro para futuras modificaciones en el algoritmo.
            d.  Facilita el mantenimiento del código al centralizar la lógica común en una clase base.

            EN:

            The Template Method Design Pattern is a behavioral pattern that defines the basic structure of an algorithm in a base class, while allowing subclasses to implement certain steps or details of the algorithm. 
            The pattern is based on the principle of inversion of control and promotes code reuse by enabling subclasses to provide customized implementations of specific parts of the algorithm without changing the overall structure.

            In summary, the Template Method Design Pattern allows defining a skeleton algorithm in a base class and delegating the implementation of concrete steps to subclasses. 
            This provides flexibility and extensibility by allowing subclasses to customize parts of the algorithm as needed.

            Benefits of the Template Method Design Pattern:

            a.  Promotes code reuse by defining a general structure in a base class and allowing subclasses to implement specific details.
            b.  Allows extension of the algorithm without changing its basic structure.
            c.  Provides a clear extension point for future modifications to the algorithm.
            d.  Facilitates code maintenance by centralizing common logic in a base class.
            */

            Console.WriteLine("Build a Concrete House\n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            //Call the Template Method to Build the Concrete House
            houseTemplate.BuildHouse();
            Console.WriteLine();
            
            Console.WriteLine("Build a Wooden House\n");
            houseTemplate = new WoodenHouse();
            //Call the Template Method to Build the Wooden House
            houseTemplate.BuildHouse();
            Console.Read();
        }
    }
}

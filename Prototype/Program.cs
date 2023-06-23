using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            ES:

            El patrón de diseño Prototype (Prototipo) se utiliza para crear objetos nuevos duplicando un objeto existente, 
            en lugar de crear nuevos objetos desde cero. 
            Este patrón se basa en la idea de clonar objetos existentes para crear nuevos objetos, 
            evitando así la necesidad de crear objetos utilizando constructores y configuraciones complejas.

            La principal ventaja del patrón Prototype es que permite la creación de nuevos objetos sin acoplar el código a clases concretas. 
            En lugar de depender de las clases específicas de los objetos que se deben crear, 
            el patrón Prototype permite clonar un objeto existente y modificarlo según sea necesario. 
            Esto facilita la creación de objetos personalizados sin tener que crear nuevas subclases o depender de interfaces complicadas.

            En C#, podemos implementar el patrón Prototype utilizando la interfaz ICloneable o utilizando un método personalizado para clonar objetos. 
            La interfaz ICloneable proporciona un método Clone que se utiliza para crear una copia superficial del objeto. 
            Sin embargo, 
            se recomienda tener cuidado al utilizar ICloneable, ya que puede generar problemas de copia incorrecta en objetos complejos o anidados.

            EN:

            EN:

            The Prototype design pattern is used to create new objects by duplicating an existing object, 
            instead of creating new objects from scratch. 
            This pattern is based on the idea of cloning existing objects to create new objects, 
            thus avoiding the need to create objects using constructors and complex configurations.

            The main advantage of the Prototype pattern is that it allows the creation of new objects without coupling the code to concrete classes. 
            Instead of relying on the specific classes of the objects to be created, 
            the Prototype pattern allows you to clone an existing object and modify it as needed. 
            This makes it easy to create custom objects without having to create new subclasses or rely on complicated interfaces.

            In C#, we can implement the Prototype pattern using the ICloneable interface or by using a custom method to clone objects. 
            The ICloneable interface provides a Clone method that is used to create a shallow copy of the object. 
            However, 
            it is recommended to be careful when using ICloneable, as it may generate incorrect copy problems on complex or nested objects.
            */

            Employee emp1 = new PermanentEmployee()
            {
                Name = "Anurag",
                Department = "IT",
                Type = "Permanent",
                Salary = 100000
            };
            
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";
            emp2.Department = "HR";
            emp1.ShowDetails();
            emp2.ShowDetails();
            
            Employee emp3 = new TemporaryEmployee()
            {
                Name = "Preety",
                Department = "HR",
                Type = "Temporary",
                FixedAmount = 200000
            };
            
            Employee emp4 = emp3.GetClone();
            emp4.Name = "Priyanka";
            emp4.Department = "Sales";
            emp3.ShowDetails();
            emp4.ShowDetails();

            Console.Read();
        }
    }
}
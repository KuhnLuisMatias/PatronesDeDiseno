using Constructor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ES:
                El patrón de diseño Dependency Injection (Inyección de Dependencias) es un patrón que permite separar la creación y
                gestión de dependencias de los objetos, de manera que las dependencias sean proporcionadas desde el exterior en lugar de
                ser creadas internamente por el objeto mismo. Esto facilita la flexibilidad, la reutilización y el mantenimiento del
                código.

                En C#, la inyección de dependencias se puede implementar de varias formas, siendo los métodos más comunes el Constructor
                Injection (Inyección por Constructor), el Property Injection (Inyección por Propiedad) y el Method Injection (Inyección
                por Método).

            EN:
                The Dependency Injection design pattern is a pattern that allows separating the creation and management of object
                dependencies, so that dependencies are provided from the outside instead of being created internally by the object
                itself. This facilitates code flexibility, reusability and maintainability.

                In C#, dependency injection can be implemented in several ways, the most common methods being Constructor Injection,
                Property Injection and Method Injection.
            */

            var employeeBL = new EmployeeBL(new EmployeeDA());
            var ListEmployee = employeeBL.GetAllEmployees();
            
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }

            Console.ReadKey();
        }
    }
}

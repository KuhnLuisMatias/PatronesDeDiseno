using Method.DataAccess;
using Method.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:
                    La inyección de dependencias por método se utiliza cuando la dependencia es esencial y necesaria para el
                    funcionamiento del método en particular. 
                    En lugar de tener una propiedad pública que se establece desde el exterior,
                    el método recibe la dependencia como argumento al ser llamado. Esto permite que se proporcione una implementación
                    específica de la dependencia cada vez que se llama al método.

                EN:
                    Dependency injection by method is used when the dependency is essential and necessary for the operation of the
                    particular method. 
                    Instead of having a public property that is set from the outside,
                    the method receives the dependency as an argument when called. This allows a specific implementation of the
                    dependency to be provided each time the method is called.
             */

            var employeeBL = new EmployeeBL();
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDA());

            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();

        }
    }
}

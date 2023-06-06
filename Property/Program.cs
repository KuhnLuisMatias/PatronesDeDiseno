using Property.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                ES:
                    La inyección de dependencias por propiedad se utiliza cuando la dependencia es opcional o puede tener un valor
                    predeterminado. 
                    Es decir, la clase que recibe la dependencia tiene una propiedad pública que puede ser establecida
                    desde el exterior y la clase puede funcionar sin la dependencia asignada. 
                    Esto puede ser útil en escenarios donde la dependencia no es esencial para el funcionamiento básico de la clase,
                    pero puede ser utilizada opcionalmente para mejorar o extender su funcionalidad.

                EN:
                    Dependency injection by property is used when the dependency is optional or may have a default value.
                    default value. 
                    That is, the class that receives the dependency has a public property that can be set from the outside and the class
                    can function without the dependency assigned.
                    This can be useful in scenarios where the dependency is not essential to the basic functioning of the class, but can
                    be optionally used to enhance or extend its functionality.
             */

            var employee = new EmployeeBL();
            employee.EmployeeDataObject = new EmployeeDA();
            
            var listEmployees = employee.GetAllEmployees();
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }

            Console.ReadKey();
        }
    }
}

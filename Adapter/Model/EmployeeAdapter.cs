using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    public class EmployeeAdapter : ThirdPartyBillingSystem, ITarget
    {
        //The following will accept the employees in the form of string array
        //Then convert the employee string array to List of Employees
        //After conversation, it will call the Adaptee's Method to Process the Salaries
        public void ProcessCompanySalary(string[,] employeesArray)
        {
          
            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                string id = employeesArray[i, 0];
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                string salary = employeesArray[i, 3];

                listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            
            //Call the Base Class ProcessSalary Method to Process the Salary
            ProcessSalary(listEmployee);
        }
    }

}

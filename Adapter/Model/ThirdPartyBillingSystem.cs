using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (var employee in listEmployee)
                Console.WriteLine($"$ {employee.Salary} Salary Credited to {employee.Name} Account");
        }
    }
}

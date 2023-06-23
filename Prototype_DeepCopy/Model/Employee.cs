using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_DeepCopy.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }
        
        public Employee GetShallowCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            return employee;
        }
        
        public Employee GetDeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();
            employee.EmpAddress = EmpAddress.GetClone();
            return employee;
        }
    }
}

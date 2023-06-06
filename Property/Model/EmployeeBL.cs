using Property.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Model
{
    public class EmployeeBL //BL: Business Logic
    {
        public IEmployee employeeDA;
        public IEmployee EmployeeDataObject
        {
            set
            {
                this.employeeDA = value;
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDA.SelectAllEmployees();
        }
    }
}

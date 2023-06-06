using Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Model
{
    public class EmployeeBL //BL: Business Logic
    {
        public List<Employee> GetAllEmployees(IEmployee employeeDA)
        {
            return employeeDA.SelectAllEmployees();
        }
    }
}

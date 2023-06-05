using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Model
{
    public class EmployeeBL
    {
        public IEmployee _employeeDA;
        public EmployeeBL(IEmployee employeeDA)
        {
            _employeeDA = employeeDA;
        }
        public List<Employee> GetAllEmployees()
        {
            return _employeeDA.SelectAllEmployees();
        }
    }
}
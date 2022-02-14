using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_ASSIGNMENT.Models;

namespace WEB_API_ASSIGNMENT.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployee();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
    }
}

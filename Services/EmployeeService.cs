using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_ASSIGNMENT.IServices;
using WEB_API_ASSIGNMENT.Models;

namespace WEB_API_ASSIGNMENT.Services
{
    public class EmployeeService : IEmployeeService
    {
        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _db)
        {
            dbContext = _db;
        }
        public IEnumerable<Employee> GetEmployee()
        {
            var employee = dbContext.Employee.ToList();
            return employee;
        }
        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                dbContext.Employee.Add(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }
        public Employee GetEmployeeById(int id)
        {
            var employee = dbContext.Employee.FirstOrDefault(x => x.Id == id);
            return employee;
        }
    }
}

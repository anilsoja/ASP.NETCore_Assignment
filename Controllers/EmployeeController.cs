using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_ASSIGNMENT.IServices;
using WEB_API_ASSIGNMENT.Models;

namespace WEB_API_ASSIGNMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employee)
        {
            employeeService = employee;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IEnumerable<Employee> GetEmployee()
        {
            return employeeService.GetEmployee();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public Employee AddEmployee(Employee employee)
        {
            return employeeService.AddEmployee(employee);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeId")]
        public Employee GetEmployeeId(int id)
        {
            return employeeService.GetEmployeeById(id);
        }
    }
}

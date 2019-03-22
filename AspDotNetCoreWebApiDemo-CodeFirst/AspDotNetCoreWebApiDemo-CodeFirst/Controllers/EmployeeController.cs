using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreWebApiDemo_CodeFirst.IRespository;
using AspDotNetCoreWebApiDemo_CodeFirst.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebApiDemo_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository _employeeRepository { get; set; }
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        //api/Employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var result = _employeeRepository.GetEmployee();
            if (result == null)
            {
                return NotFound("The Employee records couldn't be found.");
            }
            return Ok(result);
        }

        //api/Employee/1
        [HttpGet("{id}")]
        public IActionResult GetEmployee(long id)
        {
            var employee = _employeeRepository.GetEmployee();
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            return Ok(employee);
        }

        //api/Employee/1
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }
            _employeeRepository.Add(employee);
            return CreatedAtRoute(
                  "Employee",
                  new { Id = employee.EmployeeId },
                  employee);
        }
        [HttpPut,HttpPatch]
        public IActionResult Update(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");
            }

            Employee employeeToUpdate = _employeeRepository.GetEmployee(employee.EmployeeId);
            if (employeeToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            _employeeRepository.Update(employeeToUpdate,employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Employee employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            _employeeRepository.Delete(employee);
            return NoContent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreWebApiDemo_CodeFirst.IRespository;
using AspDotNetCoreWebApiDemo_CodeFirst.Model;

namespace AspDotNetCoreWebApiDemo_CodeFirst.Repository
{
    public class EmployeeRespository : IEmployeeRepository
    {       
        readonly TestDbContext _dBRepositoryContext;

        public EmployeeRespository(TestDbContext dBRepositoryContext)
        {
            _dBRepositoryContext = dBRepositoryContext;           
        }

        public Employee GetEmployee(long id)
        {
            return _dBRepositoryContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var data = _dBRepositoryContext.Employees;
            return data;
        }

        public void Add(Employee employee)
        {
            _dBRepositoryContext.Employees.Add(employee);
            _dBRepositoryContext.SaveChanges();
        }

        public void Update(Employee employeeToUpdate , Employee employee)
        {
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.DateOfBirth = employee.DateOfBirth;
            employeeToUpdate.PhoneNumber = employee.PhoneNumber;

            _dBRepositoryContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _dBRepositoryContext.Employees.Remove(employee);
            _dBRepositoryContext.SaveChanges();
        }
    }
}

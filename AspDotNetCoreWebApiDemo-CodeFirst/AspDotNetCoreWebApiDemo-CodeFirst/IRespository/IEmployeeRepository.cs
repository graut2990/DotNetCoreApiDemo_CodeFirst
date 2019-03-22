using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreWebApiDemo_CodeFirst.Model;

namespace AspDotNetCoreWebApiDemo_CodeFirst.IRespository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(long id);

        IEnumerable<Employee> GetEmployee();

        void Add(Employee employee);

        void Update(Employee employeeToUpdate, Employee employee);

        void Delete(Employee employee);
    }
}

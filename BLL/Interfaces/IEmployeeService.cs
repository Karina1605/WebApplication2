using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployeeService
    {
        public Task AddEmployee(Employee employee);

        public Task<ICollection<Employee>> GetAllEmployees();

        public Task<Employee> GetEmployeeById(int employeeId);

        public Task<ICollection<Employee>> GetEmployeeByFilter(Expression<Func<Employee, bool>> expression);

        public Task<Employee> DeleteEmployee(int employeeId);

        public Task UpdateEmployee(Employee client);
    }
}

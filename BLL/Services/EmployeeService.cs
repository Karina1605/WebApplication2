using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Employee>> GetEmployeeByFilter(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee client)
        {
            throw new NotImplementedException();
        }
    }
}

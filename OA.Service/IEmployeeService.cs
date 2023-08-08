using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        PagedWrapper<T> GetPageResponse<T>(PaginationFilter filter);
        Employee? GetEmployee(long id);
        void InsertEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(Employee emp);
    }
}

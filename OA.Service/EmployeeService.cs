using OA.Data;
using OA.Repo;

namespace OA.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository _employeeRepository;
        
        public EmployeeService(IRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }        

        public Employee? GetEmployee(long id)
        {
            return _employeeRepository.Get(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void InsertEmployee(Employee emp)
        {
            _employeeRepository.Insert(emp);
            _employeeRepository.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            _employeeRepository.Update(emp);
            _employeeRepository.SaveChanges();
        }

        public void DeleteEmployee(Employee emp)
        {
            _employeeRepository.Delete(emp);
            _employeeRepository.SaveChanges();
        }
    }
}
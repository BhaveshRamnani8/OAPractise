using OA.WebApi.DTO;

namespace OA.WebApi
{
    public interface IEmployeeHub
    {
        public Task RefreshEmployeeList(EmployeeDto emp);
    }
}

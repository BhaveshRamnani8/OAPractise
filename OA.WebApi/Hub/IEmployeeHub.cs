using OA.WebApi.DTO;

namespace OA.WebApi
{
    public interface IEmployeeHub
    {
        Task RefreshEmployeeList(EmployeeDto emp);
    }
}

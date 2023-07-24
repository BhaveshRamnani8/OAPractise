using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.Data;
using OA.Repo;
using OA.Service;
using OA.WebApi.DTO;

namespace OA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        
        public EmployeeController(IEmployeeService empService)
        {
            employeeService = empService;
        }

        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            var empList = employeeService.GetEmployees();
            var empDtoList = new List<EmployeeDto>();

            foreach (var emp in empList)
            {
                empDtoList.Add(GetEmployeeDtoStructure(emp));
            }
            return empDtoList;
        }
        

        [HttpGet("id")]
        [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            var emp = employeeService.GetEmployee(id);

            if (emp == null)            
              return NotFound();
            
            return Ok(GetEmployeeDtoStructure(emp));
        }
                
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateEmployee(EmployeeDto empDto)
        {
            var emp = GetEmployeeStructure(empDto);
            employeeService.InsertEmployee(emp);
            empDto.Id = emp.Id;
            return CreatedAtAction(nameof(GetById), new { id = emp.Id }, empDto);
        }
        

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(int id, EmployeeDto empDto)
        {
            if (id != empDto.Id)
                return BadRequest();
            
            employeeService.UpdateEmployee(GetEmployeeStructure(empDto));
            return NoContent();
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = employeeService.GetEmployee(id);

            if (emp is null)
                return NotFound();

            employeeService.DeleteEmployee(emp);
            return NoContent();
        }

        private EmployeeDto GetEmployeeDtoStructure(Employee emp)
        {
            return new EmployeeDto()
            {
                Id = emp.Id,
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Email = emp.Email,
                Gender = emp.Gender,
                MaritalStatus = emp.MaritalStatus,
                BirthDate = emp.BirthDate,
                Hobbies = emp.Hobbies,
                Salary = emp.Salary,
                Address = emp.Address,
                CountryId = emp.CountryId,
                StateId = emp.StateId,
                CityId = emp.CityId,
                ZipCode = emp.ZipCode,
                Password = emp.Password
            };
        }

        private static Employee GetEmployeeStructure(EmployeeDto empDto)
        {
            return new Employee()
            {
                FirstName = empDto.FirstName,
                LastName = empDto.LastName,
                Email = empDto.Email,
                Gender = empDto.Gender,
                MaritalStatus = empDto.MaritalStatus,
                BirthDate = empDto.BirthDate,
                Hobbies = empDto.Hobbies,
                Salary = empDto.Salary,
                Address = empDto.Address,
                CountryId = empDto.CountryId,
                StateId = empDto.StateId,
                CityId = empDto.CityId,
                ZipCode = empDto.ZipCode,
                Password = empDto.Password
            };
        }
    }
}

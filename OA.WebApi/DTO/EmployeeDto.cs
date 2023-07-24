using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OA.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OA.WebApi.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
     
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }//todo validation


        
        public string Gender { get; set; }


        
        public int MaritalStatus { get; set; }

        
        public DateTime BirthDate { get; set; }


        
        public string Hobbies { get; set; }

        
        public object Image { get; set; }//todo store image


        public decimal Salary { get; set; }


        public string Address { get; set; }


        public int? CountryId { get; set; }
        

        public int? StateId { get; set; }



        public int? CityId { get; set; }
        

        public string ZipCode { get; set; }


        public string Password { get; set; } //todo add regex

    }
}

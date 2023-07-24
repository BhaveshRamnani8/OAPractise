using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OA.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
using OA.Data.CustomValidations;

namespace OA.WebApi.DTO
{
    public class EmployeeDto
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(1)]
        public string? Gender { get; set; }
        
        public int MaritalStatus { get; set; }

        [DateValidation]
        public DateTime BirthDate { get; set; }

        public string? Hobbies { get; set; }        
        
        [Min(5000)]
        public decimal Salary { get; set; }
        
        public string? Address { get; set; }        

        public int? CountryId { get; set; }        

        public int? StateId { get; set; }

        public int? CityId { get; set; }

        [StringLength(6, MinimumLength = 6)]
        public string? ZipCode { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

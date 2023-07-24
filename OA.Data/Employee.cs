using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace OA.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }


        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }


        [Column(TypeName = "varchar(50)")]
        [EmailAddress]
        public string Email { get; set; }


        [Column(TypeName = "varchar(1)")]
        [StringLength(1)]
        public string Gender { get; set; }


        [Column(TypeName = "int")]
        [MaxLength(1)]
        public int MaritalStatus { get; set; }


        [Column(TypeName = "dateTime")]
        public DateTime BirthDate { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string Hobbies { get; set; }


        [NotMapped]
        public object Image { get; set; }


        [Column(TypeName = "decimal(10,2)")]
        [Range(5000, 100000000000)]
        public decimal Salary { get; set; }


        [Column(TypeName = "varchar(500)")]
        public string Address { get; set; }


        [ForeignKey(nameof(Country))]
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }


        [ForeignKey(nameof(State))]
        public int? StateId { get; set; }

        public virtual State State { get; set; }


        [ForeignKey(nameof(City))]
        public int? CityId { get; set; }

        public virtual City City { get; set; }


        [Column(TypeName = "varchar(6)")]
        [StringLength(6, MinimumLength = 6)]
        public string ZipCode { get; set; }


        [Column(TypeName = "varchar(50)")]
        [StringLength(16, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
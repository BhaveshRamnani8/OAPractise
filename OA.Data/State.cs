using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public int? CountryId { get; set; }

        public virtual Country? Country { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }
    }
}

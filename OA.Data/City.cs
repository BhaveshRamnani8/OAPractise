using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(State))]
        public int? StateId { get; set; }

        public virtual State? State { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Name { get; set; }
    }
}

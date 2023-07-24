using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
        {
            //entityBuilder.HasKey(e => e.Id);
            entityBuilder.Property(e => e.FirstName).IsRequired();
            entityBuilder.Property(e => e.Email).IsRequired();
            entityBuilder.Property(e => e.Password).IsRequired();
        }
    }
}

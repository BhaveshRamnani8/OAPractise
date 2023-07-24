using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data.CustomValidations
{
    public class DateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now.AddYears(-18);
        }
    }
}

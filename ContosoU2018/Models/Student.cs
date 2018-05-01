using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public class Student:person
    {
        [Display(Name="Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyy-mmm-ddd}",ApplyFormatInEditMode = true)]

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public class person
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Province { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get { return LastName + ", " + FirstName; } }

        public string IDFullName { get { return "(" + ID + ")" + LastName + ", " + FirstName; } }
    }
}

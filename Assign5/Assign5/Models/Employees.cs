using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assign5.Models
{
    public class Employees
    {

        [Key]
        public string ssn { get; set; }
        public double salary { get; set; }
        public string phone { get; set; }


        public virtual Departments department { get; set; }
        public virtual Child child { get; set; }

    }
}
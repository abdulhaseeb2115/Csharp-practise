using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assign5.Models
{
    public class Departments
    {
        [Key]
        public int dno { get; set; }
        public string dname { get; set; }
        public double budget { get; set; }
    }
}
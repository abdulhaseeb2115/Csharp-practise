using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assign5.Models
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}
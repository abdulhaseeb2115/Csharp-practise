﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspPractise1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
    
}
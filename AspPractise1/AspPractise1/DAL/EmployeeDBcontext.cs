using AspPractise1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspPractise1.DAL
{
    public class EmployeeDBcontext : DbContext
    {
        public EmployeeDBcontext() : base("EmployeeDBContext")
        {

        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vp_Semester_Project.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Vp_Semester_Project_DBEntities : DbContext
    {
        public Vp_Semester_Project_DBEntities()
            : base("name=Vp_Semester_Project_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_Password> Admin_Password { get; set; }
        public virtual DbSet<Class_Course_Teacher> Class_Course_Teacher { get; set; }
        public virtual DbSet<Course_Reg> Course_Reg { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Student_Attendance> Student_Attendance { get; set; }
        public virtual DbSet<Student_marks> Student_marks { get; set; }
        public virtual DbSet<Student_Reg> Student_Reg { get; set; }
        public virtual DbSet<Teacher_Reg> Teacher_Reg { get; set; }
    }
}

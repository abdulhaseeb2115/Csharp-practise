//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Class_Course_Teacher
    {
        public int Id { get; set; }
        public string Class_name { get; set; }
        public int Course_id { get; set; }
        public int Teacher_id { get; set; }
    
        public virtual Course_Reg Course_Reg { get; set; }
        public virtual Teacher_Reg Teacher_Reg { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqPractise
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int Id { get; set; }
        public int pID { get; set; }
        public int dID { get; set; }
        public string AppointmentDate { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

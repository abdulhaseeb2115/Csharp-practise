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
    
    public partial class Notification
    {
        public int Id { get; set; }
        public string For { get; set; }
        public string From { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public System.DateTime Date { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ado.net_EF_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseFacultyMapping
    {
        public string CourseID { get; set; }
        public int FacultyID { get; set; }
        public Nullable<int> Priority { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
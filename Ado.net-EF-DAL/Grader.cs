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
    
    public partial class Grader
    {
        public int FacultyId { get; set; }
        public int ParticipantId { get; set; }
        public Nullable<int> TotalMarks { get; set; }
        public string AreaOfImprovement { get; set; }
        public string AreaOfExcellence { get; set; }
        public string CourseId { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Participant Participant { get; set; }
    }
}

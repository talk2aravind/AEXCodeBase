//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AEXApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fundraising
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int SubDivisionId { get; set; }
        public Nullable<decimal> AchievedTarget { get; set; }
        public string ProfileDiscription { get; set; }
        public bool isActive { get; set; }
    
        public virtual SubDivision SubDivision { get; set; }
        public virtual Member Member { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


namespace AEXApplication.Models
{
    public class GearListMetadata
    {
        [Display(Name = "Gear")]
        [StringLength(50, MinimumLength = 1)]
        public string Gear;

        [Display(Name = "Model Description")]
        [StringLength(50, MinimumLength = 1)]
        public string Model;

        [Display(Name = "Check-Out Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOut;

        [Display(Name = "Check-In Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateIn;

        [Display(Name = "Check-Out By")]
        [StringLength(50, ErrorMessage = "Check out by field cannot be longer than 50 characters.")]
        public string CheckOutBy;

        [Display(Name = "Bought On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime CreatedDate;

        [Display(Name = "Last Updated On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> UpdatedDate;

        [Display(Name = "Active")]
        public bool isActive;

    }
    public class FundraisingMetadata
    {
        public int Id { get; set; }
        [Display(Name="Name")]
        public int MemberId { get; set; }

        [Display(Name = "Sub Division Name")]
        public int SubDivisionId { get; set; }

        [Display(Name="Fund Raised till now")]
        public Nullable<decimal> AchievedTarget { get; set; }
        
        [Display(Name="Fund Raising Profile")]
        public string ProfileDiscription { get; set; }
        public bool isActive { get; set; }

        [Display(Name = "Sub Division Name")]
        public virtual SubDivision SubDivision { get; set; }
        public virtual Member Member { get; set; }

    }
    public class MemberMetadata
    {
        public int Id { get; set; }
        
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Created On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime CreatedDate { get; set; }
        
        [Display(Name = "Last Updated On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        [Display(Name = "Active")]
        public bool isActive { get; set; }
    }
    public class SubDivisionMetadata
    {
        public int Id { get; set; }

        [Display(Name = "Sub Division")]
        public string Name { get; set; }
        
        public int DivisionId { get; set; }
        
        public Nullable<decimal> FundTarget { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }


    }
    public class DivisionMetadata
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> CreatedDate { get; set; }
        
        [Display(Name = "Modified Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        
        [Display(Name = "Active")]
        public bool isActive { get; set; }

    }
}


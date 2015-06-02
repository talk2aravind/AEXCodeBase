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
        public bool isActive;

    }
}
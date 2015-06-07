using System;
using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

namespace AEXApplication.Models
{
    [MetadataType(typeof(GearListMetadata))]
    public partial class GearList
    {
    }

    [MetadataType(typeof(FundraisingMetadata))]
    public partial class Fundraising
    {
    }

    [MetadataType(typeof(MemberMetadata))]
    public partial class Member
    {
    }

    [MetadataType(typeof(SubDivisionMetadata))]
    public partial class SubDivision
    {
    }

    [MetadataType(typeof(DivisionMetadata))]
    public partial class Division
    {
    }
}
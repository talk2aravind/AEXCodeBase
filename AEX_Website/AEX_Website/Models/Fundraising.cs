using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AEXApplication.Models
{
    public class Fundraising
    {
        public int Id {get; set;}
        public string UserName {get;set;}
        public string Alias { get; set; }
    }
    public class FundraisingContext : DbContext
    {
        public DbSet<Fundraising> Fundraising { get; set; }
    }
}
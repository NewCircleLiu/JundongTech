using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JundongTech.Models.Partner
{
    public class PartnerContext:DbContext
    {
        public PartnerContext()
            : base("name=Partner-Context")
        { }


        public DbSet<Partner> partnerList {get;set;}


    }
}
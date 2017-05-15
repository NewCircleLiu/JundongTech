using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JundongTech.Models.Service
{
    public class ServiceContext : DbContext
    {
         public ServiceContext(): base("name=Service-Context")
        {

        }
        public DbSet<Service> serviceLists { get; set; }
    }
}
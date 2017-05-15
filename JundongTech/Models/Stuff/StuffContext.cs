using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace JundongTech.Models.Stuff
{
    public class StuffContext:DbContext
    {
        public StuffContext(): base("name=Stuff-Context")
        {

        }
        public DbSet<Stuff> stuffLists { get; set; }
    }
}
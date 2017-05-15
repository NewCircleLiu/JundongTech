using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JundongTech.Models.Contact
{
    public class ContactContext:DbContext
    {
        public ContactContext()
            : base("name=Contact-Context")
        { }

       public DbSet<Contact> contactList { get; set; }

    }
}
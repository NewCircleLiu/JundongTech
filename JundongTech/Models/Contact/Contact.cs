using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using JundongTech.Models.Service;

namespace JundongTech.Models.Contact
{
    public class Contact
    {
        [Key]
        public int contact_id { get; set; }
        public string contact_email { get; set; }
        public string contact_name { get; set; }
        public string contact_subject { get; set; }
        public string contact_message { get; set; }
    }
}
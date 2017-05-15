using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace JundongTech.Models.Stuff
{
    public class Stuff
    {
        [Key]
        public int stuff_id { get; set; } //id
        public string stuff_name { get; set; }//姓名
        public string stuff_email { get; set; } //email
        public string stuff_work { get; set; } //职位
        public string stuff_description { get; set; } //个人简介
        public string stuff_image { get; set; } //头像
    }
}
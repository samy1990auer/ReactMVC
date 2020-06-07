using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReactMVC.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}
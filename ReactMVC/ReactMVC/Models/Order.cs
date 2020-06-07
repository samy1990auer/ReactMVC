using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReactMVC.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalPaid { get; set; }
        public DateTime OrderDate { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }

    }
}
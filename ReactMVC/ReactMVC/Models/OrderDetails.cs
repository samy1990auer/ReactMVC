using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReactMVC.Models
{
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int FoodItemID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace ReactMVC.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("MyString")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
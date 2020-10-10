using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string phone { get; set; }
    }
}

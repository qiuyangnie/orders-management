using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OrdersManagement.Models
{
    public class OrderViewModel
    {
        public List<Order> Orders { get; set; }
        public SelectList CustomerIds { get; set; }
        public int CustomerId { get; set; }
    }
}

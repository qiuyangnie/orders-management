using System;

namespace OrdersManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EstimateDate { get; set; }
        public int CustomerId { get; set; }
    }
}

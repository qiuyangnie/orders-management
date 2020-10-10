using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EstimateDate { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer{ get; set; }

        public IList<OrderDetail> OrderDetail { get; set; }
    }
}

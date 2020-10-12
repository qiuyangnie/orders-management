using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrdersManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EstimateDate { get; set; }

        public Status Status { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer{ get; set; }

        public IList<OrderDetail> OrderDetail { get; set; }
    }
}

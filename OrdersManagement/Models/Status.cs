using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersManagement.Models
{
    public class Status
    {
        [Key]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string Name { get; set; }
    }
}

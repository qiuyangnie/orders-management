using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersManagement.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExpiredDate { get; set; }
    }
}

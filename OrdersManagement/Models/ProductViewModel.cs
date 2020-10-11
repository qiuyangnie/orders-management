using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace OrdersManagement.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Descriptions { get; set; }
        public string ProductDescription { get; set; }
        public string SearchString { get; set; }
    }
}

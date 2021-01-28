using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetProjectM7.Models
{
    public class ProductCls
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductQTY { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
        public string ProductImage { get; set; }
    }
}
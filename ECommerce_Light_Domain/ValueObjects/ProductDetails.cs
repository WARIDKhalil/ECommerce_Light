using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.ValueObjects
{
    public class ProductDetails
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public ProductDetails() { }
    }
}

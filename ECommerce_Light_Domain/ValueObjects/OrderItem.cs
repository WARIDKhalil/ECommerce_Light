using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.ValueObjects
{
    public class OrderItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; } 

        public OrderItem() { }
    }
}

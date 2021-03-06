using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.ValueObjects
{
    /// <summary>
    ///  Represents Infos of an item in Order
    /// </summary>
    public class OrderItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; } 

        public OrderItem() { }
    }
}

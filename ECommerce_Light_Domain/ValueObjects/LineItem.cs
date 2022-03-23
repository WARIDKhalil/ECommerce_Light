using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.ValueObjects
{
    /// <summary>
    ///   Represents infos of an Item in a Cart
    /// </summary>
    public class LineItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }

        public LineItem() { }
    }
}

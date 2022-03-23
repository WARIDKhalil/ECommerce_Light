using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.ValueObjects
{
    /// <summary>
    ///     Represents The geo-graphical infos
    /// </summary>
    public class Adress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int ZIP { get; set; }
        public string Street { get; set; }
        public string Extra { get; set; }

        public Adress() { }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Enumerations
{
    /// <summary>
    ///  The state of a specific order
    /// </summary>
    public enum OrderState
    {
        New,
        Shipped,
        Delivred,
        Closed
    }

    /// <summary>
    ///  Helpers
    /// </summary>
    public static class OrderStateHelper
    {

    }
}

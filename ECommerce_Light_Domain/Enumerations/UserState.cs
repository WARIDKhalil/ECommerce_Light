using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Enumerations
{
    /// <summary>
    ///  The state of a specific user
    /// </summary>
    public enum UserState
    {
        New,
        Active,
        Inactive,
        Blocked,
        Banned,
    }

    /// <summary>
    ///  Helpers
    /// </summary>
    public static class UserStateHelper
    {

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.DBSettings
{
    /// <summary>
    ///  Shared properties to establish a connection with a database
    /// </summary>
    public class DBSettings
    {
        /// <summary>
        ///     Name of database
        /// </summary>
        public string DatabaseName { get; set; }
        /// <summary>
        ///     URL to establish the connection with the database server
        /// </summary>
        public string ConnectionString { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared
{
    /// <summary>
    ///     Shared Informations among all entities
    /// </summary>
    /// <typeparam name="T">Id type</typeparam>
    public interface IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}

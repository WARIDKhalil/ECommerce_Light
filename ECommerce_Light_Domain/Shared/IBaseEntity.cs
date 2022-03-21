using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Domain.Shared
{
    public interface IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}

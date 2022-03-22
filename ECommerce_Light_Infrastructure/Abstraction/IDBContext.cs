using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Abstraction
{
    public interface IDBContext
    {
        object GetClassifier<T>(string collectionName);
    }
}

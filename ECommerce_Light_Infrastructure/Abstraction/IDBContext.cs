using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Abstraction
{
    /// <summary>
    ///  Shared method(s) among DbContext classes
    /// </summary>
    public interface IDBContext
    {
        object GetClassifier<T>(string collectionName);
    }
}

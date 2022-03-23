using ECommerce_Light_Domain.Shared;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_Light_Infrastructure.Mappers
{
    /// <summary>
    ///  Maps POCOs while de/serializing the documents
    /// </summary>
    public static class GenericMapper
    {
        public static void MapClass<T,TId>() where T : IBaseEntity<TId>
        {
            BsonClassMap.RegisterClassMap<T>(cm => {
                cm.AutoMap();
                cm.MapIdMember(c => c.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
                cm.SetIgnoreExtraElements(true);
            });
        }

        public static void MapSubClass<T, TId>() where T : IBaseEntity<TId>
        {
            BsonClassMap.RegisterClassMap<T>(cm => {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
        }

        public static void MapRootClass<T, TId>() where T : IBaseEntity<TId>
        {
            BsonClassMap.RegisterClassMap<T>(cm => {
                cm.AutoMap();
                cm.SetIsRootClass(true);
                cm.MapIdMember(c => c.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
                cm.SetIgnoreExtraElements(true);
            });
        }

    }
}

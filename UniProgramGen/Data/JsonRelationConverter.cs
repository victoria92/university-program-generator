using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniProgramGen.Data
{
    class JsonRelationConverter<T> : JsonConverter where T:MongoDocument
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T[]);
        }

        public override T ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<T>(reader);
            var result = new List<T>();


            return result.ToArray();
        }


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
/*
public class User
{
    public string Name { get; set; }
    [JsonConverter(typeof(RolesConverter))]
    public Role[] Roles { get; set; }
}
*/
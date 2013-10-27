
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace UniProgramGen.Data
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomType
    {
        // TODO: add more types
        Lecture,
        Computer,
        Projector,
        Komin
    }
}

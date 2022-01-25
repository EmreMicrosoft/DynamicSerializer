using System.Text.Json;
using System.Text.Json.Serialization;

namespace DynamicSerializer;

public class DynamicConverter : JsonConverter<Dynamic>
{
    public override Dynamic Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // TODO
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, Dynamic value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        //foreach (var keyValuePair in value._dictionary)
        //    writer.WriteString(keyValuePair.Key, keyValuePair.Value.ToString());
        foreach (var (key, o) in value._dictionary)
            writer.WriteString(key, o.ToString());

        writer.WriteEndObject();
    }
}
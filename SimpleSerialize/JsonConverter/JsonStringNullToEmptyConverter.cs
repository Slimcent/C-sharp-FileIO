using SimpleSerialize.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimpleSerialize.JsonConverter
{
    public class JsonStringNullToEmptyConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }
            return value;
        }

        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            value ??= string.Empty;
            writer.WriteStringValue(value);
        }

        public static void HandleNullStrings()
        {
            Console.WriteLine("Handling Null Strings");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = null,
                IncludeFields = true,
                WriteIndented = true,
                Converters = { new JsonStringNullToEmptyConverter() },
            };
            //Create a new object with a null string
            var radio = new Radio
            {
                HasSubWoofers = true,
                HasTweeters = true,
                RadioId = null
            };
            //serialize the object to JSON
            var json = JsonSerializer.Serialize(radio, options);
            Console.WriteLine(json);
        }
    }
}

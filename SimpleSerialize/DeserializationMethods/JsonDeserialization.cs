using System.Text.Json;

namespace SimpleSerialize.DeserializationMethods
{
    public static class JsonDeserialization
    {
        public static T ReadAsJsonFormat<T>(string fileName) =>
            JsonSerializer.Deserialize<T>(File.ReadAllText(fileName));
    }
}

using System.Text.Json;

namespace SimpleSerialize.SerializationMethods
{
    public class JsonSerialization
    {
        public static void SaveAsJsonFormat<T>(T objGraph, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };
            File.WriteAllText(fileName, JsonSerializer.Serialize(objGraph, options));
        }
    }
}

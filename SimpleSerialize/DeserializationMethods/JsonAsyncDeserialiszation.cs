using System.Text.Json;

namespace SimpleSerialize.DeserializationMethods
{
    public static class JsonAsyncDeserialiszation
    {
        public async static void DeserializeAsync()
        {
            Console.WriteLine("Async Deserialization");
            var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("[0,1,2,3,4]"));
            await foreach (int item in JsonSerializer.DeserializeAsyncEnumerable<int>(stream))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

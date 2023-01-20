using System.Text.Json;

namespace SimpleSerialize.SerializationMethods
{
    public static class JsonAsynSerialization
    {
        static async IAsyncEnumerable<int> PrintNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return i;
            }
        }

        public async static void SerializeAsync()
        {
            Console.WriteLine("Async Serialization");

            using Stream stream = Console.OpenStandardOutput();
            var data = new { Data = PrintNumbers(6) };

            await JsonSerializer.SerializeAsync(stream, data);
            Console.WriteLine();
        }
    }
}

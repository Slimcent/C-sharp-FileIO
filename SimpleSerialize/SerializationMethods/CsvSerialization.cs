using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Text;
using SimpleSerialize.Models;

namespace SimpleSerialize.SerializationMethods
{
    public static class CsvSerialization
    {
        public static void WriteToCsv()
        {
            var filepath = "something.csv";
            using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
            FileMode.Create, FileAccess.Write)))
            {
                writer.WriteLine("sep=,");
                writer.WriteLine("Hello, Goodbye");
            }
        }

        public static void WriteToCSV()
        {
            string data = "Col1, Col2, Col2";
            string filePath = @"cols.csv";
            File.WriteAllText(filePath, data);
            string dataFromRead = File.ReadAllText(filePath);
            Console.WriteLine(dataFromRead);
        }

        public static void SaveToCSV()
        {
            var users = new List<User>()
            {
                new User() { FirstName = "John", LastName = "Doe", Occupation = "Farmer"},
                new User() { FirstName = "Steph", LastName = "Nnam", Occupation = "Enginner"}
            };

            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ",",
                Encoding = Encoding.UTF8
            };

            using (var writer = new StreamWriter("myUser.csv"))
            using (var csvWriter = new CsvWriter(writer, csvConfig))
            {
                csvWriter.WriteHeader<User>();
                csvWriter.WriteRecords(users);
                Console.WriteLine("Records written successfully");
            }
        }
    }
}

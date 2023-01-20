using CsvHelper;
using CsvHelper.Configuration;
using SimpleSerialize.Models;
using System.Globalization;

namespace SimpleSerialize.DeserializationMethods
{
    public static class CsvDeserialization
    {
        public static void ReadCsvToObjects()
        {
            // Reading csv files into object
            StreamReader streamReader = File.OpenText($"C:/Users/obinn/source/Bezao/LearningFileIO/SimpleSerialize/Files/dept.csv"); 
            CsvReader csvReader = new(streamReader, CultureInfo.CurrentCulture);

            IEnumerable<Department> departments = csvReader.GetRecords<Department>();

            foreach (Department department in departments)
            {
                Console.WriteLine($"{department.Id} {department.Name}");
            }
            Console.WriteLine();
        }

        public static void ReadCsvWithSemicolonUsingDynamic()
        {
            //using Dynamic to read semicolon cs file
            CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                AllowComments = true,
                Delimiter = ";",
                //Delimiter = "\";\"",
                //Mode = CsvMode.Escape
            };

            StreamReader streamReader = File.OpenText($"C:/Users/obinn/source/repos/Linq/Csv/File/Department.csv");
            CsvReader csvReader = new CsvReader(streamReader, csvConfig);

            var departments = csvReader.GetRecords<dynamic>();

            foreach (dynamic dynamicObject in departments)
            {
                string id = Convert.ToString(dynamicObject.Field1);
                string name = Convert.ToString(dynamicObject.Field2);
                               
                Console.WriteLine($"{id} {name}");
            }
            Console.WriteLine();
        }
    }
}

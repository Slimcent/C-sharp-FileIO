using CsvHelper.Configuration.Attributes;

namespace SimpleSerialize.Models
{
    public class Department
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string Name { get; set; }
    }
}


using BinaryWriterReaderApp;
using SimpleSerialize.DeserializationMethods;
using SimpleSerialize.JsonConverter;
using SimpleSerialize.Models;
using SimpleSerialize.SerializationMethods;
using SimpleSerialize.SerializationOperations;
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("***** Fun with Object Serialization *****\n");
var theRadio = new Radio
{
    StationPresets = new() { 89.3, 105.1, 97.1 },
    HasTweeters = true
};
// Make a JamesBondCar and set state.
JamesBondCar jbc = new()
{
    CanFly = true,
    CanSubmerge = false,
    TheRadio = new()
    {
        StationPresets = new() { 89.3, 105.1, 97.1 },
        HasTweeters = true
    }
};

List<JamesBondCar> myCars = new()
{
 new JamesBondCar { CanFly = true, CanSubmerge = true, TheRadio = theRadio },
 new JamesBondCar { CanFly = true, CanSubmerge = false, TheRadio = theRadio },
 new JamesBondCar { CanFly = false, CanSubmerge = true, TheRadio = theRadio },
 new JamesBondCar { CanFly = false, CanSubmerge = false, TheRadio = theRadio },
};
Person p = new Person
{
    FirstName = "James",
    IsAlive = true
};


//XmlSerialization.SaveAsXmlFormat(jbc, "CarData.xml");
//Console.WriteLine("=> Saved car in XML format!");

//XmlSerialization.SaveAsXmlFormat(p, "PersonData.xml");
//Console.WriteLine("=> Saved person in XML format!");

//XmlSerialization.SaveAsXmlFormat(myCars, "CarCollection.xml");
//Console.WriteLine("=> Saved list of cars!");


//JamesBondCar savedCar = XmlDeserialization.ReadAsXmlFormat<JamesBondCar>("CarData.xml");
//Console.WriteLine("Original Car:\t {0}", jbc.ToString());
//Console.WriteLine("Read Car:\t {0}\n", savedCar.ToString());

//List<JamesBondCar> savedCars = XmlDeserialization.ReadAsXmlFormat<List<JamesBondCar>>("CarCollection.xml");

//foreach (var item in savedCars)
//{
//    Console.WriteLine(item.CanSubmerge);
//}


//JsonSerialization.SaveAsJsonFormat(jbc, "CarData.json");
//Console.WriteLine("=> Saved car in JSON format!");

//JsonSerialization.SaveAsJsonFormat(p, "PersonData.json");
//Console.WriteLine("=> Saved person in JSON format!");

//JsonSerialization.SaveAsJsonFormat(myCars, "CarCollection.json");
//Console.WriteLine("=> Saved CarCollection in JSON format!");

//JsonAsynSerialization.SerializeAsync();

//JsonAsyncDeserialiszation.DeserializeAsync();

//JamesBondCar savedJsonCar = JsonDeserialization.ReadAsJsonFormat<JamesBondCar>("CarData.json");
//Console.WriteLine("Read Car: {0}", savedJsonCar.ToString());

//List<JamesBondCar> savedJsonCars = JsonDeserialization.ReadAsJsonFormat<List<JamesBondCar>>("CarCollection.json");
//foreach (var car in savedJsonCars)
//{
//    Console.WriteLine("Read Car: {0}", car);
//}

//CsvSerialization.WriteToCsv();
//CsvSerialization.WriteToCSV();
//CsvSerialization.SaveToCSV();

//CsvDeserialization.ReadCsvToObjects();

//CsvDeserialization.ReadCsvWithSemicolonUsingDynamic();

//JsonStringNullToEmptyConverter.HandleNullStrings();
using System.Xml.Serialization;

namespace SimpleSerialize.DeserializationMethods
{
    public class XmlDeserialization
    {
        public static T ReadAsXmlFormat<T>(string fileName)
        {
            // Create a typed instance of the XmlSerializer
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));

            using (Stream fStream = new FileStream(fileName, FileMode.Open))
            {
                T obj = default;

                obj = (T)xmlFormat.Deserialize(fStream);
                return obj;
            }
        }
    }
}

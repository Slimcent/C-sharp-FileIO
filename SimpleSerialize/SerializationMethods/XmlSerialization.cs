using System.Xml.Serialization;

namespace SimpleSerialize.SerializationOperations
{
    public static class XmlSerialization
    {
        public static void SaveAsXmlFormat<T>(T objGraph, string fileName)
        {
            //Must declare type in the constructor of the XmlSerializer
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }
    }
}

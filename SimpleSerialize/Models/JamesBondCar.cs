using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace SimpleSerialize.Models
{
    public class JamesBondCar : Car
    {
        [XmlAttribute]
        [JsonInclude]
        public bool CanFly;

        [XmlAttribute]
        [JsonInclude]
        public bool CanSubmerge;
        public override string ToString() => 
            $"CanFly:{CanFly}, CanSubmerge:{CanSubmerge} {base.ToString()}";
    }
}

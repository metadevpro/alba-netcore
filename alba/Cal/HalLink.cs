using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class HalLink
    {
        [DataMember]
        public string Href { get; set; }
        [DataMember]
        public string Verb { get; set; }
        [DataMember]
        public string Template { get; set; }
    }
}

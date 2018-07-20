using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class MetaResponse
    {
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public int Offset { get; set; }
        [DataMember]
        public int Limit { get; set; }
    }
}

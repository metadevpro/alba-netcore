using System.Collections.Generic;
using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class DiagnosisResponse
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Version{ get; set; }
        [DataMember]
        public IEnumerable<Check> Checks { get; set; }
    }
    [DataContract]
    public class Check
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Desc { get; set; }
        [DataMember]
        public bool Result { get; set; }
    }
}

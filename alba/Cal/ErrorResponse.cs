using System.Collections.Generic;
using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class ErrorResponse
    {
        [DataMember]
        public string Error { get; set; }
        [DataMember]
        public string Description{ get; set; }
        [DataMember]
        public string Template { get; set; }
        [DataMember]
        public KeyValuePair<string, string> Args { get; set; }
        [DataMember]
        public object Context { get; set; }

    }
}

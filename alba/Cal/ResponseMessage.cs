using System.Collections.Generic;
using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class ResponseMessage<T>
    {
        [DataMember]
        public MetaResponse Meta { get; set; }
        [DataMember]
        public IEnumerable<T> Data { get; set; }
        [DataMember(Name ="_links")]
        public IEnumerable<KeyValuePair<string, HalLink>> Links { get; set; }
    }
}

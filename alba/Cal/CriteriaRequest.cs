using System.Collections.Generic;
using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class CriteriaRequest
    {
        [DataMember]
        public bool Count { get; set; }
        [DataMember]
        public string Order { get; set; }
        [DataMember]
        public int Offset { get; set; }
        [DataMember]
        public int Limit { get; set; }
        [DataMember]
        public string GroupBy { get; set; }
        [DataMember]
        public IEnumerable<CriteriaClause> Where { get; set; }
        [DataMember]
        public bool Distinct { get; set; }
        [DataMember]
        public string Projection { get; set; }

    }

    [DataContract]
    public class CriteriaClause
    {
        [DataMember]
        public string Operator { get; set; }
        [DataMember]
        public string Field { get; set; }
        [DataMember]
        public object Value { get; set; }
        [DataMember]
        public IEnumerable<CriteriaClause> Clauses { get; set; }
    }
}

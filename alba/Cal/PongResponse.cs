using System.Runtime.Serialization;

namespace alba.Cal
{
    [DataContract]
    public class PongResponse
    {
        private static PongResponse Singleton;

        [DataMember]
        public string msg
        {
            get
            {
                return "pong";
            }
        }

        public static PongResponse Response()
        {
            if (Singleton == null)
            {
                Singleton = new PongResponse();
            }
            return Singleton;
        }
    }
}

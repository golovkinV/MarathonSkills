using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationClasses
{
    [DataContract]
    public class EventType
    {
        [DataMember]
        public string id;

        [DataMember]
        public string name;

        public EventType(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

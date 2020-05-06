using System;
using System.Runtime.Serialization;

namespace SerializationClasses
{
    [DataContract]
    public class KitOption
    {
        [DataMember]
        public string id;

        [DataMember]
        public string name;

        [DataMember]
        public double cost;

        public KitOption(string id, string name, string cost)
        {
            this.id = id;
            this.name = name;
            this.cost = Convert.ToDouble(cost);
        }

        public KitOption(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

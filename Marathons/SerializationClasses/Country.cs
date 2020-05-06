using System;
using System.Runtime.Serialization;

namespace SerializationClasses
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public string code;

        [DataMember]
        public string name;

        public Country(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}

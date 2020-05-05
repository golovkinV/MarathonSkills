using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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

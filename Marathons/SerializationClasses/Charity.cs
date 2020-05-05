using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationClasses
{
    [DataContract]
    public class Charity
    {

        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string desc;

        [DataMember]
        public string logo;

        public Charity(string id, string name, string desc, string logo)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.desc = desc;
            this.logo = logo;
        }
    }
}

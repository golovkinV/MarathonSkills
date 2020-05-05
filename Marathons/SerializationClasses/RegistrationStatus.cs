using System;
using System.Runtime.Serialization;


namespace SerializationClasses
{
    [DataContract]
    public class RegistrationStatus
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        public RegistrationStatus(string id, string name)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
        }
    }
}

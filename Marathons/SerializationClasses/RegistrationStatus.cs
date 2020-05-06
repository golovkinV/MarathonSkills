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

        [DataMember]
        public readonly int registrationId;

        public RegistrationStatus(string id, string name, string registrationId)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.registrationId = Convert.ToInt32(registrationId);
        }

        public RegistrationStatus(string id, string name)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
        }
    }
}

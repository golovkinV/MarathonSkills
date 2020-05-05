using System;
using System.Runtime.Serialization;

namespace SerializationClasses
{
    [DataContract]
    public class Sponsor
    {

        [DataMember]
        public int id;

        [DataMember]
        public int registrationId;

        [DataMember]
        public string name;

        [DataMember]
        public double amount;

        [DataMember]
        public int charityId;

        public Sponsor(string id, string name, string registrationId, string amount, string charityId)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.registrationId = Convert.ToInt32(registrationId);
            this.amount = Convert.ToDouble(amount);
            this.charityId = Convert.ToInt32(charityId);
        }
    }
}

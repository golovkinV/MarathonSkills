using System;
using System.Runtime.Serialization;


namespace SerializationClasses
{
    [DataContract]
    public class Runner
    {
        [DataMember]
        public int id;

        [DataMember]
        public int registrationId;

        [DataMember]
        public string firstName;

        [DataMember]
        public string lastName;

        [DataMember]
        public string country;

        [DataMember]
        public double sponsorshipTarget;

        [DataMember]
        public Charity charity;

        public Runner(string id, string registrationId,
            string firstName, string lastName, string country, string sponsorshipTarget, Charity charity)
        {
            this.id = Convert.ToInt32(id);
            this.registrationId = Convert.ToInt32(registrationId);
            this.firstName = firstName;
            this.lastName = lastName;
            this.country = country;
            this.sponsorshipTarget = Convert.ToDouble(sponsorshipTarget);
            this.charity = charity;
        }
    }
}
